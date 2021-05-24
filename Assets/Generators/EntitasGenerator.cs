namespace EcsGenerator
{
    public class EntitasGenerator : BaseGenerator
    {
        public EntitasGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
        {
        }
        
        public override void Generate()
        {
            base.Generate();
            GenerateComponents();
            //GenerateRunner();
            //GenerateSystems();
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
            var output = "[Game]\n";
            output += $"public sealed class Component{c.Id} : IComponent \n";
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
            pre += "using Entitas;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.Entitas{\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }
    }
}