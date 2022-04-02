﻿using System;
using Leopotam.Ecs;

namespace EcsGenerator.LeoEcs
{
    public class LeoEcsCodeGenerator : BaseGenerator
    {
        protected override void GenerateRunner()
        {
            var fileContent = "";
            fileContent += "class LeoEcsRunner : MonoBehaviour, IEcsRunner {\n";
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

            SaveToFile("LeoEcsRunner.cs", fileContent);
        }

        private string GenInfo()
        {
            var output = "public void GenInfo(){\n";
            output += " var s = _world.GetStats();\n";
            output += " Debug.Log(\"e \" + s.ActiveEntities + \" c \" + s.Components);\n";
            output += "}\n";
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

        protected override string GenerateSystem(DslSystem s)
        {
            var output = $"class System{s.Id} : IEcsRunSystem";
            output += "{\n";

            output += " EcsWorld _world = null;\n";
            output += " EcsFilter<";

            for (var index = 0; index < s.FiltersComponents.Count; index++)
            {
                var component = s.FiltersComponents[index];
                output += $"Component{component.Id},";
            }

            output = output.TrimEnd(',');
            output += "> _filter = null;\n";


            output += " public void Run () {\n";
            //output += "  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {\n";
            output += "  foreach (var i in _filter) {\n";

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
            var output = "";
            var firstComponentTag = s.FiltersComponents[0].Fields.Count == 0;
            if (!firstComponentTag)
            {
                output += "   ref var component1 = ref _filter.Get1 (i);\n";
            }

            var hasSecondComponent = s.FiltersComponents.Count > 1;
            var secondComponentTag = true;
            if (hasSecondComponent && s.FiltersComponents[1].Fields.Count > 0)
            {
                secondComponentTag = false;
                output += "   ref var component2 = ref _filter.Get2 (i);\n";
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
            var c = s.LogicComponents[0];
            output += "   ref var entity = ref _filter.GetEntity (i);\n";
            output += $"   if (entity.Has<Component{c.Id}>())\n";
            output += "   {\n";
            output += $"    entity.Del<Component{c.Id}>();\n";
            output += "   }\n";
            output += "   else\n";
            output += "   {\n";
            output += $"    entity.Replace(new Component{c.Id}());\n";
            output += "   }\n";

            return output;
        }
        
        private static string HasGetBody(DslSystem s)
        {
            var output = "   var q = 0;\n";
           
            output += "   ref var entity = ref _filter.GetEntity (i);\n";
            for (int i = 0; i < s.LogicComponents.Count; i++) {
                var c = s.LogicComponents[i];
                output += $"   if (entity.Has<Component{c.Id}>())\n";
                output += "   {\n";
                output += $"    q+=1;\n";
                output += $"    var com = entity.Get<Component{c.Id}>();\n";
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
            var c = s.LogicComponents[0];
            output += "   var e = _world.NewEntity();\n";
            output += "   e.Replace(new TicksCooldownComponent(10));\n";
            output += $"   e.Replace(new Component{c.Id}());\n";
            
            return output;
        }
        
        
        protected override string DecorateNamespace(string fileContent)
        {
            var pre = "";
            pre += "using System;\n";
            pre += "using Leopotam.Ecs;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.LeoEcs{\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }

        protected override string GenerateComponent(DslComponent c)
        {
            var output = "";
            if (c.Fields.Count > 0)
            {
                output += $"public struct Component{c.Id}\n";
            }
            else
            {
                output += $"public struct Component{c.Id} : IEcsIgnoreInFilter\n";
            }

            output += "{\n";
            for (var index = 0; index < c.Fields.Count; index++)
            {
                var field = c.Fields[index];
                output += $"public {PresetGenerator.GetFieldType(field)} Field{index};\n";
            }

            output += "}\n\n";
            return output;
        }

        private string GenerateEntity(DslEntity e)
        {
            var output = $"var entity{e.Id} = _world.NewEntity();\n";

            for (var index = 0; index < e.Components.Count; index++)
            {
                var component = e.Components[index];
                output += $"entity{e.Id}.Replace(new Component{component.Id}());\n";
            }

            output += "\n";
            return output;
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

        public LeoEcsCodeGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
        {
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

    internal class TickCounterSystem : IEcsRunSystem{
        private EcsWorld _world = null;
        private EcsFilter<TicksCooldownComponent> _filter = null;
        public void Run () {
            foreach (var i in _filter) {
                ref var cooldownComponent = ref _filter.Get1 (i);
                cooldownComponent.Ticks -= 1;
                if (cooldownComponent.Ticks <= 0)
                {
                    ref var entity = ref _filter.GetEntity (i);
                    entity.Destroy();
                }
            }
        }
    }
}