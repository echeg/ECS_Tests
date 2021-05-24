using System;

namespace EcsGenerator
{
    public class LeoLiteEcsCodeGenerator: BaseGenerator
    {
        public override void Generate()
        {
            base.Generate();
            GenerateComponents();
            GenerateRunner();
            GenerateSystems();
        }
        
        public LeoLiteEcsCodeGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
        {
        }
        
        void GenerateComponents()
        {
            var fileContent = "";
            foreach (var component in _dataProvider.GetComponents())
            {
                fileContent += GenerateComponent(component);
            }

            SaveToFile("Components.cs", fileContent);
        }
        
        void GenerateRunner()
        {
            var name = "LeoEcsLiteRunner";
            var fileContent = "";
            fileContent += $"class {name} : MonoBehaviour, IEcsRunner {{\n";
            fileContent += "EcsWorld _world;\n";
            fileContent += "EcsSystems _systems;\n\n";

            fileContent += "public void Init() {\n";
            fileContent += "    _world = new EcsWorld();\n";
            fileContent += "    _systems = new EcsSystems(_world)\n";
            fileContent += GenerateListSystems();
            fileContent += "   _systems.Init ();\n";
            fileContent += "}\n\n";


            fileContent += "public void Run() {\n";
            fileContent += "_systems.Run();\n";
            fileContent += "}\n\n";

            fileContent += "public void GenStartEntities() {\n";
            fileContent += GenerateEntities();
            fileContent += "}\n";


            fileContent += "}\n";

            SaveToFile(name+".cs", fileContent);
        }
        
        string GenerateComponent(DslComponent c)
        {
            var output = "";
            output += $"public struct Component{c.Id}\n";
            /*
            if (c.Fields.Count > 0)
            {
                output += $"public struct Component{c.Id}\n";
            }
            else
            {
                output += $"public struct Component{c.Id} : IEcsIgnoreInFilter\n";
            }
            */

            output += "{\n";
            for (var index = 0; index < c.Fields.Count; index++)
            {
                var field = c.Fields[index];
                output += $"public {PresetGenerator.GetFieldType(field)} Field{index};\n";
            }

            output += "}\n\n";
            return output;
        }
        
        protected override string DecorateNamespace(string fileContent)
        {
            var pre = "";
            pre += "using System;\n";
            pre += "using Leopotam.EcsLite;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.LeoEcsLite{\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }
        
        string GenerateListSystems()
        {
            var output = "";
            foreach (var system in _dataProvider.GetSystems())
            {
                output += $" .Add(new System{system.Id}())\n";
            }

            output += ";\n";

            return output;
        }
        
        string GenerateEntities()
        {
            var fileContent = "";
            foreach (var entity in _dataProvider.GetEntities())
            {
                fileContent += GenerateEntity(entity);
            }

            return fileContent;
        }
        
        string GenerateEntity(DslEntity e)
        {
            var output = $"var entity{e.Id} = _world.NewEntity();\n";

            for (var index = 0; index < e.Components.Count; index++)
            {
                var component = e.Components[index];
                output += $"_world.GetPool<Component{component.Id}>().Add(entity{e.Id});\n";
            }

            output += "\n";
            return output;
        }
        
        private void GenerateSystems()
        {
            var fileContent = "";
            foreach (var system in _dataProvider.GetSystems())
            {
                fileContent += GenerateSystem(system);
            }

            SaveToFile("Systems.cs", fileContent);
        }
        
        string GenerateSystem(DslSystem s)
        {
            var output = $"class System{s.Id} : IEcsInitSystem, IEcsRunSystem";
            output += "{\n";

            output += " EcsWorld _world = null;\n";
            output += " EcsFilter _filter;\n";
            
            for (var index = 0; index < s.FiltersComponents.Count; index++)
            {
                var component = s.FiltersComponents[index];
                output += $"EcsPool<Component{component.Id}> _p{index+1};\n";
            }

            if (s.SystemType == TypeSystem.ComponentAddAndRemove)
            {
                output += $"EcsPool<Component{s.LogicComponent.Id}> _pl;\n";
            }
            
            
            output += " public void Init (EcsSystems systems) {\n";
            output += "  _world = systems.GetWorld ();\n";
            
            output += "  _filter = _world.Filter";

            for (var index = 0; index < s.FiltersComponents.Count; index++)
            {
                var component = s.FiltersComponents[index];
                if (index == 0)
                {
                    output += $"<Component{component.Id}>().";
                }
                else
                {
                    output += $"Inc<Component{component.Id}>().";
                }
            }
            
            output += "End();\n";
            
            
            for (var index = 0; index < s.FiltersComponents.Count; index++)
            {
                var component = s.FiltersComponents[index];
                output += $"   _p{index+1} = _world.GetPool<Component{component.Id}>();\n";
            }
            if (s.SystemType == TypeSystem.ComponentAddAndRemove)
            {
                output += $"   _pl = _world.GetPool<Component{s.LogicComponent.Id}>();\n";
            }

            
            
            output += " }\n";

            output += " public void Run (EcsSystems systems) {\n";
            output += "  var entities = _filter.GetRawEntities();\n";
            output += "  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){\n";

            switch (s.SystemType)
            {
                case TypeSystem.OnlyCalculate:
                    output += CalculateBody(s);
                    break;
                
                case TypeSystem.ComponentAddAndRemove:
                    output += AddRemoveBody(s);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            
            output += "  }\n";
            output += " }\n";
            output += "}\n\n";
            return output;
        }
        
        private static string CalculateBody(DslSystem s)
        {
            var output = "";
            var firstComponentTag = s.FiltersComponents[0].Fields.Count == 0;
            if (!firstComponentTag)
            {
                output += "   ref var component1 = ref _p1.Get (entities[i]);\n";
            }

            var hasSecondComponent = s.FiltersComponents.Count > 1;
            var secondComponentTag = true;
            if (hasSecondComponent && s.FiltersComponents[1].Fields.Count > 0)
            {
                secondComponentTag = false;
                output += "   var component2 = _p2.Get (entities[i]);\n";
            }

            if (!firstComponentTag && hasSecondComponent && !secondComponentTag)
            {
                output += "   component1.Field0 += component2.Field0;\n";
            }
            else if (!firstComponentTag)
            {
                output += "   component1.Field0 += 1;\n";
            }

            return output;
        }
        
        private static string AddRemoveBody(DslSystem s)
        {
            var output = "";
            
            output += "   var entity = entities[i];\n";
            output += "   if (_pl.Has(entity))\n";
            output += "   {\n";
            output += $"    _pl.Del(entity);\n";
            output += "   }\n";
            output += "   else\n";
            output += "   {\n";
            output += $"    _pl.Add(entity);\n";
            output += "   }\n";

            return output;
        }
    }
}