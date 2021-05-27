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
            fileContent += "    _em = World.DefaultGameObjectInjectionWorld.EntityManager;\n";
            fileContent += "    DefaultWorldInitialization.Initialize(\"world\",true);\n";
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
                //fileContent += GenerateSystem(system);
            }

            SaveToFile("Systems.cs", fileContent);
        }
    }
}