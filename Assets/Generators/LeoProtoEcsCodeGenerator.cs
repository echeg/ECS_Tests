using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;

namespace EcsGenerator.LeoProto {
    public class LeoProtoEcsCodeGenerator : BaseGenerator {
        public LeoProtoEcsCodeGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider) {}

        protected override void GenerateRunner() {
            var name = "LeoEcsProtoRunner";
            var fileContent = "";
            fileContent += $"class {name} : MonoBehaviour, IEcsRunner {{\n";
            fileContent += "ProtoWorld _world;\n";
            fileContent += "ProtoSystems _systems;\n\n";

            fileContent += "public void Init() {\n";
            fileContent += "    _world = new ProtoWorld (new Aspect1 ());\n";
            fileContent += "    _systems = new ProtoSystems (_world)\n";
            fileContent += " .AddModule(new AutoInjectModule ())\n";
            fileContent += " .AddSystem(new TickCounterSystem());\n";
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

            fileContent += GenAspect();
            SaveToFile(name + ".cs", fileContent);
        }

        private string GenAspect() {
            var aspect = "public class Aspect1 : IProtoAspect  {\n";
            // public ProtoPool<Component1> C1Pool;
            aspect += " public void Init (ProtoWorld world) {\n";

            aspect += "world.AddAspect (this);\n";

            //C1Pool = new ProtoPool<Component1> ();

            aspect += " world.AddPool (C1Pool);\n";
            aspect += " }\n";
            aspect += "}\n";

            return aspect;
        }

        public static string RemoveLastChar(string s) {
            return string.IsNullOrEmpty(s)
                ? null
                : (s[..^1]);
        }

        protected override string GenerateSystem(DslSystem s) {
            var output = $"class System{s.Id} : IProtoInitSystem, IProtoRunSystem";
            output += "{\n";

            output += " ProtoWorld _world = null;\n";
            output += " Aspect1 _aspect = null;\n";
            output += " ProtoIt _it;\n";

            output += " public void Init (IProtoSystems systems) {\n";
            output += "  _world = systems.World ();\n";
            output += "  _aspect = (Aspect1) world.Aspect (typeof (Aspect1));\n";
            output += " _it = new ProtoIt (new [] {";

            for (var index = 0; index < s.FiltersComponents.Count; index++) {
                var component = s.FiltersComponents[index];
                output += $"typeof(Component{component.Id}),";
            }
            output = RemoveLastChar(output);

            output += " } );\n";

            output += "  _it.Init (world);\n";
            output += " }\n";

            output += " public void Run (EcsSystems systems) {\n";

            output += "  foreach (int entity in _filter) {\n";

            /*
            output += s.SystemType switch
            {
                TypeSystem.OnlyCalculate => CalculateBody(s),
                TypeSystem.ComponentAddAndRemove => AddRemoveBody(s),
                TypeSystem.CreateRemoveEntity => CreateEntityBody(s),
                TypeSystem.HasGetComponents => HasGetBody(s),
                _ => throw new ArgumentOutOfRangeException()
            };
            */

            output += "  }\n";
            output += " }\n";
            output += "}\n\n";
            return output;
        }

        protected override string GenerateComponent(DslComponent c) {
            var output = "";
            output += $"public struct Component{c.Id}\n";

            output += "{\n";
            for (var index = 0; index < c.Fields.Count; index++) {
                var field = c.Fields[index];
                output += $"public {PresetGenerator.GetFieldType(field)} Field{index};\n";
            }

            output += "}\n\n";
            return output;
        }

        private string GenerateListSystems() {
            var output = "";
            foreach (var system in _dataProvider.GetSystems()) {
                //output += $" .Add(new System{system.Id}())\n";
                output += $" _systems.AddSystem(new System{system.Id}());\n";
            }

            output += ";\n";

            return output;
        }

        private string GenerateEntities() {
            var fileContent = "";
            foreach (var entity in _dataProvider.GetEntities()) {
                //fileContent += GenerateEntity(entity);
            }

            return fileContent;
        }

        protected override string DecorateNamespace(string fileContent) {
            var pre = "";
            pre += "using System;\n";
            pre += "using Leopotam.EcsProto;\n";
            pre += "using Leopotam.EcsProto.QoL;\n";
            pre += "using System.Collections.Generic;\n";
            pre += "using System.Globalization;\n";
            pre += "using UnityEngine;\n";
            pre += "namespace EcsGenerator.LeoProto{\n\n\n";

            var post = "}\n";

            return pre + fileContent + post;
        }

        private string GenInfo() {
            var output = "public void GenInfo(){\n";
            output += " Debug.Log(\"e \" + _world.GetAliveEntities());\n";
            output += "}\n";
            return output;
        }
    }
}