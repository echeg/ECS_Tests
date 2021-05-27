using System;
using Unity.Entities;

namespace EcsGenerator.UEcs
{
    public class UnityEcsGenerator : BaseGenerator
    {
        public UnityEcsGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
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
            fileContent += "    DefaultWorldInitialization.Initialize(\"world\",true);\n";
            fileContent += "    _em = World.DefaultGameObjectInjectionWorld.EntityManager;\n";
            fileContent += "    World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<SimulationSystemGroup>().Enabled = false;\n";
            fileContent += "    World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<PresentationSystemGroup>().Enabled = false;\n";
            fileContent += "    _simSystems = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<SimulationSystemGroup>().Systems;\n";
            fileContent += "    _presSystems = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<PresentationSystemGroup>().Systems;\n";
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
            pre += "using System;\n";
            pre += "using Unity.Entities;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.UEcs{\n\n\n";

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
            var fileContent = "";
            foreach (var system in _dataProvider.GetSystems())
            {
                fileContent += GenerateSystem(system);
            }

            SaveToFile("Systems.cs", fileContent);
        }
        
        string GenerateSystem(DslSystem s)
        {
            var output = $"class System{s.Id} : SystemBase";
            output += "{\n";

            output += " private EntityQuery _notifyGroup;\n";
            output += "  EntityManager _em;\n";


            output += " protected override void OnCreate(){\n";
            output += "  base.OnCreate();\n";
            output += "  _em = EntityManager;\n";
            output += "  RequireForUpdate(_notifyGroup);\n";
            output += " }\n";
        

            output += "  protected override void OnUpdate(){\n";

            switch (s.SystemType)
            {
                case TypeSystem.OnlyCalculate:
                    output += CalculateBody(s);
                    break;
            }
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

            output += $"Entities.WithoutBurst()\n.WithStoreEntityQueryInField(ref _notifyGroup)\n{filters}\n.ForEach((";
            for (var index = 0; index < 2; index++)
            {
                if (index >= s.FiltersComponents.Count) break;
                var component = s.FiltersComponents[index];
                output += $"ref Component{component.Id} c{index+1},";
            }
            output=output.TrimEnd(',');

            output += " ) =>{";
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
    
    public class TickCounterSystem : SystemBase
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
            Entities.WithoutBurst()
                .WithStoreEntityQueryInField(ref _notifyGroup)
                .WithAll<TicksCooldownComponent>()
                .ForEach((Entity e, ref TicksCooldownComponent tick) =>
                {
                    tick.Ticks -= 1;
                    if (tick.Ticks<=0)
                    {
                        _em.DestroyEntity(e);
                    }
                }).Run();

        }
    }
}