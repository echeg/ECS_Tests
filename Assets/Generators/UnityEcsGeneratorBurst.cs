using System;
using EcsGenerator;
using Unity.Entities;

namespace EcsGenerator.UEcsBurst
{
    public class UnityEcsGeneratorBurst : BaseGenerator
    {
        public UnityEcsGeneratorBurst(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath,
            dataProvider)
        {
        }

        public override void Generate()
        {
            base.Generate();
            GenerateComponents();
            GenerateRunner();
            GenerateSystems();
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

        string GenerateComponent(DslComponent c)
        {
            var output = "";
            output += $"public struct Component{c.Id} : IComponentData\n";

            output += "{\n";
            for (var index = 0; index < c.Fields.Count; index++)
            {
                var field = c.Fields[index];
                output += $"public {PresetGenerator.GetFieldType(field)} Field{index};\n";
            }

            output += "}\n\n";
            return output;
        }

        void GenerateRunner()
        {
            var fileContent = "";
            var filename = "UEcsRunner";
            fileContent += $"class {filename} : MonoBehaviour, IEcsRunner {{\n";
            fileContent += "EntityManager _em;\n";
            fileContent += "IReadOnlyList<ComponentSystemBase> _simSystems;\n";
            fileContent += "IReadOnlyList<ComponentSystemBase> _presSystems;\n\n";

            fileContent += "public void Init() {\n";
            
            fileContent += "#if UNITY_EDITOR\n";
            fileContent += "   var isEditorWorld = !EditorApplication.isPlaying;\n";
            fileContent += "#else\n";
            fileContent += "   var isEditorWorld = false;\n";
            fileContent += "#endif\n";
            
            fileContent += "    DefaultWorldInitialization.Initialize(\"world\",isEditorWorld);\n";
            fileContent += "    _em = World.DefaultGameObjectInjectionWorld.EntityManager;\n";
            fileContent +=
                "    World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<SimulationSystemGroup>().Enabled = false;\n";
            fileContent +=
                "    World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<PresentationSystemGroup>().Enabled = false;\n";
            fileContent +=
                "    _simSystems = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<SimulationSystemGroup>().Systems;\n";
            fileContent +=
                "    _presSystems = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<PresentationSystemGroup>().Systems;\n";
            //fileContent += "   _systems.Init ();\n";
            fileContent += "}\n\n";


            fileContent += "public void Run() {\n";
            fileContent += "foreach(var sys in _simSystems){sys.Update();}\n";
            fileContent += "foreach(var sys in _presSystems){sys.Update();}\n";
            fileContent += "}\n\n";

            fileContent += "public void GenStartEntities() {\n";
            fileContent += GenerateEntities();
            fileContent += "}\n";

            fileContent += GenInfo();

            fileContent += "}\n";

            SaveToFile(filename + ".cs", fileContent);
        }

        protected override string DecorateNamespace(string fileContent)
        {
            var pre = "";
            pre += "#if UNITY_EDITOR\n";
            pre += "using UnityEditor;\n";
            pre += "#endif\n";
            pre += "using System;\n";
            pre += "using Unity.Entities;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.UEcsBurst{\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }

        string GenInfo()
        {
            var output = "public void GenInfo(){\n";
            output += " Debug.Log(\"e \" + World.DefaultGameObjectInjectionWorld.EntityManager.EntityCapacity);\n";
            output += "}\n";
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
            var output = $"var entity{e.Id} = _em.CreateEntity();\n";

            for (var index = 0; index < e.Components.Count; index++)
            {
                var component = e.Components[index];
                output += $"_em.AddComponent<Component{component.Id}>(entity{e.Id});\n";
            }

            output += "\n";
            return output;
        }

        private void GenerateSystems()
        {
            var list = _dataProvider.GetSystems();
            for (var index = 0; index < list.Count; index++)
            {
                var system = list[index];
                var fileContent = GenerateSystem(system);
                SaveToFile($"Systems{index}.cs", fileContent);
            }
        }

        string GenerateSystem(DslSystem s)
        {
            var output = $"[AlwaysUpdateSystem]class System{s.Id} : SystemWithBuffer";
            output += "{\n";

            output += " private EntityQuery _notifyGroup;\n";
            output += "  EntityManager _em;\n";


            output += " protected override void OnCreate(){\n";
            output += "  base.OnCreate();\n";
            output += "  _em = EntityManager;\n";
            //output += "  RequireForUpdate(_notifyGroup);\n";
            output += " }\n";


            output += "  protected override void OnUpdate(){\n";

            output += s.SystemType switch
            {
                TypeSystem.OnlyCalculate => CalculateBody(s),
                TypeSystem.ComponentAddAndRemove => AddRemoveBody(s),
                TypeSystem.CreateRemoveEntity => CreateEntityBody(s),
                _ => throw new ArgumentOutOfRangeException()
            };
            output += " }\n";
            output += "}\n\n";
            return output;
        }

        private static string CalculateBody(DslSystem s)
        {
            var output = "";
            var filters = "";
            if (s.FiltersComponents.Count > 2)
            {
                filters = ".WithAll<";
                for (var index = 2; index < s.FiltersComponents.Count; index++)
                {
                    var component = s.FiltersComponents[index];
                    filters += "Component" + component.Id + ",";
                }

                filters = filters.TrimEnd(',');
                filters += ">()";
            }

            output += $"Entities\n{filters}\n.ForEach((";
            for (var index = 0; index < 2; index++)
            {
                if (index >= s.FiltersComponents.Count) break;
                var component = s.FiltersComponents[index];
                output += $"ref Component{component.Id} c{index + 1},";
            }

            output = output.TrimEnd(',');

            output += " ) =>{\n";


            if (s.FiltersComponents.Count > 1 && s.FiltersComponents[0].Fields.Count > 1 &&
                s.FiltersComponents[1].Fields.Count > 1)
            {
                output += "c1.Field0 += c2.Field0;\n";
            }

            output += " }).Run();\n";
            return output;
        }

        private static string AddRemoveBody(DslSystem s)
        {
            var output = "var ecb = _addCommandBufferSystem.CreateCommandBuffer();\n";
            var filters = "";

            filters = ".WithAll<";
            for (var index = 0; index < Math.Min(s.FiltersComponents.Count, 3); index++)
            {
                var component = s.FiltersComponents[index];
                filters += "Component" + component.Id + ",";
            }

            filters = filters.TrimEnd(',');
            filters += ">()";


            output += $"Entities\n{filters}\n";
            output += ".ForEach((Entity e) =>{\n";
            output += $"if (HasComponent<Component{s.LogicComponent.Id}>(e))\n";
            output += "   {\n";
            output += $"    ecb.RemoveComponent<Component{s.LogicComponent.Id}>(e);\n";
            output += "   }\n";
            output += "   else\n";
            output += "   {\n";
            output += $"    ecb.AddComponent<Component{s.LogicComponent.Id}>(e);\n";
            output += "   }\n";
            
            output += " }).Run();";
            return output;
        }
        
        private static string CreateEntityBody(DslSystem s)
        {
            var output = "var ecb = _addCommandBufferSystem.CreateCommandBuffer();\n";
            var filters = "";

            filters = ".WithAll<";
            for (var index = 0; index < Math.Min(s.FiltersComponents.Count, 3); index++)
            {
                var component = s.FiltersComponents[index];
                filters += "Component" + component.Id + ",";
            }

            filters = filters.TrimEnd(',');
            filters += ">()";


            output += $"Entities\n{filters}\n";
            output += ".ForEach((Entity e) =>{\n";
            
            output += "   var e1 = ecb.CreateEntity();\n";
            output += "   ecb.AddComponent(e1, new TicksCooldownComponent(10));\n";
            output += $"  ecb.AddComponent(e1, new Component{s.LogicComponent.Id}());\n";
            
            output += " }).Run();";
            return output;
        }
    }
    
    public struct TicksCooldownComponent : IComponentData
    {
        public int Ticks;

        public TicksCooldownComponent(int ticks)
        {
            Ticks = ticks;
        }
    }
    
    public class SystemWithBuffer : SystemBase
    {
        protected AddEndSimulationEntityCommandBufferSystem _addCommandBufferSystem;

        protected override void OnCreate()
        {
            _addCommandBufferSystem = World.GetOrCreateSystem<AddEndSimulationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate()
        {
        }
    }
    
    [UnityEngine.ExecuteAlways]
    [UpdateInGroup(typeof(LateSimulationSystemGroup))]
    public class AddEndSimulationEntityCommandBufferSystem : EntityCommandBufferSystem {}

    public class TickCounterSystem : SystemWithBuffer
    {
        private EntityQuery _notifyGroup;
        private EntityManager _em;

        protected override void OnCreate()
        {
            base.OnCreate();
            _em = EntityManager;
            RequireForUpdate(_notifyGroup);
        }

        protected override void OnUpdate()
        {
            if (_notifyGroup.CalculateEntityCount() == 0) return;
            var ecb = _addCommandBufferSystem.CreateCommandBuffer();
            Entities
                .WithStoreEntityQueryInField(ref _notifyGroup)
                .WithAll<TicksCooldownComponent>()
                .ForEach((Entity e, ref TicksCooldownComponent tick) =>
                {
                    tick.Ticks -= 1;
                    if (tick.Ticks <= 0)
                    {
                        ecb.DestroyEntity(e);
                    }
                }).Run();
        }
    }
}