using System;
using Leopotam.EcsLite;

namespace EcsGenerator.LeoEcsLite2
{
    public class LeoLite2EcsCodeGenerator: BaseGenerator
    {
        public LeoLite2EcsCodeGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
        {
        }

        protected override void GenerateRunner()
        {
            var name = "LeoEcsLite2Runner";
            var fileContent = "";
            fileContent += $"class {name} : MonoBehaviour, IEcsRunner {{\n";
            fileContent += "EcsWorld _world;\n";
            fileContent += "EcsSystems _systems;\n\n";

            fileContent += "public void Init() {\n";
            fileContent += "    _world = new EcsWorld();\n";
            fileContent += "    _systems = new EcsSystems(_world)\n";
            fileContent += " .Add(new TickCounterSystem());\n";
            fileContent += GenerateListSystems();
            fileContent += "   _systems.Init ();\n";
            fileContent += "}\n\n";


            fileContent += "public void Run() {\n";
            fileContent += "_systems.Run();\n";
            fileContent += "}\n\n";

            fileContent += "public void GenStartEntities() {\n";
            fileContent += GenerateEntities();
            fileContent += "}\n";

            fileContent += GenInfo();
            
            fileContent += "}\n";

            SaveToFile(name+".cs", fileContent);
        }

        private string GenInfo()
        {
            var output = "public void GenInfo(){\n";
            output += " Debug.Log(\"e \" + _world.GetAllocatedEntitiesCount());\n";
            output += "}\n";
            return output;
        }

        protected override string GenerateComponent(DslComponent c)
        {
            var output = "";
            output += $"public struct Component{c.Id}\n";

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
            pre += "namespace EcsGenerator.LeoEcsLite2 {\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }

        private string GenerateListSystems()
        {
            var output = "";
            foreach (var system in _dataProvider.GetSystems())
            {
                output += $" _systems.Add(new System{system.Id}());\n";
            }

            output += ";\n";

            return output;
        }

        private string GenerateEntities()
        {
            var fileContent = "";
            foreach (var entity in _dataProvider.GetEntities())
            {
                fileContent += GenerateEntity(entity);
            }

            return fileContent;
        }

        private static string GenerateEntity(DslEntity e)
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

        protected override string GenerateSystem(DslSystem s)
        {
            var output = $"class System{s.Id} : IEcsInitSystem, IEcsRunSystem";
            output += "{\n";

            output += " EcsWorld _world = null;\n";
            output += " EcsFilter _filter;\n";

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

            output += " }\n";

            output += " public void Run (EcsSystems systems) {\n";

            output += "  foreach (int entity in _filter) {\n";

            output += s.SystemType switch
            {
                TypeSystem.OnlyCalculate => CalculateBody(s),
                TypeSystem.ComponentAddAndRemove => AddRemoveBody(s),
                TypeSystem.CreateRemoveEntity => CreateEntityBody(s),
                TypeSystem.HasGetComponents => HasGetBody(s),
                _ => throw new ArgumentOutOfRangeException()
            };

            output += "  }\n";
            output += " }\n";
            output += "}\n\n";
            return output;
        }
        
        private static string CalculateBody(DslSystem s)
        {
            //var output = "   var entity = entities[i];\n";
            var output = "";
            var firstComponentTag = s.FiltersComponents[0].Fields.Count == 0;
            if (!firstComponentTag)
            {
                output += $"   ref var component1 = ref _world.GetPool<Component{s.FiltersComponents[0].Id}>().Get(entity);\n";
            }

            var hasSecondComponent = s.FiltersComponents.Count > 1;
            var secondComponentTag = true;
            if (hasSecondComponent && s.FiltersComponents[1].Fields.Count > 0)
            {
                secondComponentTag = false;
                output += "   ref var component2 = ref _world.GetPool<Component{s.FiltersComponents[1].Id}>.Get(entity);\n";
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
            
            output += $"   if (_world.GetPool<Component{s.LogicComponents[0].Id}>().Has(entity))\n";
            output += "   {\n";
            output += $"    _world.GetPool<Component{s.LogicComponents[0].Id}>().Del(entity);\n";
            output += "   }\n";
            output += "   else\n";
            output += "   {\n";
            output += $"    _world.GetPool<Component{s.LogicComponents[0].Id}>().Add(entity);\n";
            output += "   }\n";

            return output;
        }
        
        private static string HasGetBody(DslSystem s)
        {
            var output = "  var q = 0;\n";

            for (int i = 0; i < s.LogicComponents.Count; i++) {
                output += $"   if (_world.GetPool<Component{s.LogicComponents[i].Id}>().Has(entity))\n";
                output += "   {\n";
                output += $"    q+=1;\n";
                output += $"    var component1 = _world.GetPool<Component{s.LogicComponents[i].Id}>().Get(entity);\n";
                output += "   }\n";
                output += "   else\n";
                output += "   {\n";
                output += $"    q-=1;\n";
                output += "   }\n";
            }

            return output;
        }
        
        private static string CreateEntityBody(DslSystem s)
        {
            var output = "";
            output += "   var e = _world.NewEntity();\n";
            output += $"   ref var c1 = ref _world.GetPool<Component{s.LogicComponents[0].Id}>().Add(e);\n";
            output += $"   ref var tick = ref _world.GetPool<TicksCooldownComponent>().Add(e);\n";
            output += $"   tick.Ticks=10;\n";
            
            return output;
        }
    }
    
    public struct TicksCooldownComponent
    {
        public int Ticks;

        public TicksCooldownComponent(int ticks)
        {
            Ticks = ticks;
        }
    }

    internal class TickCounterSystem : IEcsInitSystem, IEcsRunSystem{
        private EcsWorld _world = null;
        private EcsFilter _filter;
        private EcsPool<TicksCooldownComponent> _p1;
            
        public void Init (EcsSystems systems) {
            _world = systems.GetWorld ();
            _filter = _world.Filter<TicksCooldownComponent>().End();
            _p1 = _world.GetPool<TicksCooldownComponent>();
        }
            
        public void Run(EcsSystems systems)
        {
            var entities = _filter.GetRawEntities();
            foreach (var entity in _filter) {
                ref var cooldownComponent = ref _p1.Get(entity);
                cooldownComponent.Ticks -= 1;
                if (cooldownComponent.Ticks <= 0)
                {
                    _world.DelEntity(entity);
                }
            }
        }

    }
}