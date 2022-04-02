using System;
using Entitas;

namespace EcsGenerator.Entitas
{
    public class EntitasGenerator : BaseGenerator
    {
        public EntitasGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) : base(workWorkPath, dataProvider)
        {
        }

        protected override string GenerateComponent(DslComponent c)
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

        protected override void GenerateRunner()
        {
            var name = "EntitasRunner";
            var fileContent = "";
            fileContent += $"class {name} : MonoBehaviour, IEcsRunner {{\n";
            fileContent += "GameContext _context;\n";
            fileContent += "Systems _systems;\n\n";

            fileContent += "public void Init() {\n";
            fileContent += "    _context = Contexts.sharedInstance.game;\n";
            fileContent += "    _systems = new Feature(\"world\")\n";
            fileContent += " .Add(new TickCounterSystem(_context));\n";
            fileContent += GenerateListSystems();
            fileContent += ";\n";
            fileContent += "   _systems.Initialize ();\n";
            fileContent += "}\n\n";


            fileContent += "public void Run() {\n";
            fileContent += "_systems.Execute();\n";
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
            output += "Debug.Log(Contexts.sharedInstance.game.count+\" c \"+Contexts.sharedInstance.game.totalComponents);\n";
            output += "}\n";
            return output;
        }

        private string GenerateListSystems()
        {
            var output = "";
            foreach (var system in _dataProvider.GetSystems())
            {
                output += $" _systems.Add(new System{system.Id}(_context));\n";
            }

            output += ";\n";

            return output;
        }

        protected override string GenerateSystem(DslSystem s)
        {
            var output = $"class System{s.Id} : IExecuteSystem";
            output += "{\n";

            output += "  readonly GameContext _context;\n";
            output += "  private readonly IGroup<GameEntity> _group;\n";
            
            output += $"  public System{s.Id}(GameContext context)\n";
            output += "  {\n";
            output += "  _context = context;\n";
            
            var filter = "";
            for (var index = 0; index < s.FiltersComponents.Count; index++)
            {
                var component = s.FiltersComponents[index];
                filter += $"GameMatcher.EcsGeneratorEntitasComponent{component.Id},";
            }
            filter = filter.TrimEnd(',');
            
            
            output += $"  _group = _context.GetGroup(GameMatcher.AllOf({filter}));\n";
            output += "  }\n";

           
            output += " public void Execute() {\n";
            output += "  var entities = _group.GetEntities();\n";
            output += "  for (var i = 0; i<entities.Length; i++) {\n";

            output += s.SystemType switch {
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

        private string GenerateEntities()
        {
            var fileContent = "";
            foreach (var entity in _dataProvider.GetEntities())
            {
                fileContent += GenerateEntity(entity);
            }

            return fileContent;
        }

        private string GenerateEntity(DslEntity e)
        {
            var output = $"var entity{e.Id} = _context.CreateEntity();\n";

            for (var index = 0; index < e.Components.Count; index++)
            {
                var component = e.Components[index];
                output += $"entity{e.Id}.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent{component.Id},new Component{component.Id}());\n";
            }

            output += "\n";
            return output;
        }
        
        private static string CalculateBody(DslSystem s)
        {
            var output = "   var e = entities[i];\n";
            var firstComponentTag = s.FiltersComponents[0].Fields.Count == 0;
            if (!firstComponentTag)
            {
                output += $"   var component1 = e.ecsGeneratorEntitasComponent{s.FiltersComponents[0].Id};\n";
            }

            var hasSecondComponent = s.FiltersComponents.Count > 1;
            var secondComponentTag = true;
            if (hasSecondComponent && s.FiltersComponents[1].Fields.Count > 0)
            {
                secondComponentTag = false;
                output += $"   var component2 = e.ecsGeneratorEntitasComponent{s.FiltersComponents[1].Id};\n";
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
        
        private static string HasGetBody(DslSystem s)
        {
            var output = "   var q = 0;";
            
            output += "   var entity = entities[i];\n";
            
            for (int i = 0; i < s.LogicComponents.Count; i++) {
                var c = s.LogicComponents[i];
                output += $"   if (entity.hasEcsGeneratorEntitasComponent{c.Id})\n";
                output += "   {\n";
                output += $"    entity.getEcsGeneratorEntitasComponent{c.Id}();\n";
                output += $"    q+=1;\n";
                output += "   }\n";
                output += "   else\n";
                output += "   {\n";
                output += $"    q-=1;\n";
                output += "   }\n";
            }

            return output;
        }
        
        private static string AddRemoveBody(DslSystem s)
        {
            var output = "";
            
            output += "   var entity = entities[i];\n";
            var c = s.LogicComponents[0];
            if (c.Fields.Count > 0)
            {
                output += $"   if (entity.hasEcsGeneratorEntitasComponent{c.Id})\n";
                output += "   {\n";
                output += $"    entity.RemoveEcsGeneratorEntitasComponent{c.Id}();\n";
                output += "   }\n";
                output += "   else\n";
                output += "   {\n";
                output +=
                    $"    entity.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent{c.Id},new Component{c.Id}());\n";
                output += "   }\n";
            }
            else
            {
                output += $"   if (entity.isEcsGeneratorEntitasComponent{c.Id})\n";
                output += "   {\n";
                output += $"    entity.isEcsGeneratorEntitasComponent{c.Id}=false;\n";
                output += "   }\n";
                output += "   else\n";
                output += "   {\n";
                output += $"    entity.isEcsGeneratorEntitasComponent{c.Id}=true;\n";
                output += "   }\n";
            }

            return output;
        }
        
        private static string CreateEntityBody(DslSystem s)
        {
            var c = s.LogicComponents[0];
            var output = "";
            output += "   var e = _context.CreateEntity();\n";
            output += "   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));\n";
            output += $"   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent{c.Id},new Component{c.Id}());\n";
            
            return output;
        }
    }
    
    [Game]
    public sealed class TicksCooldownComponent : IComponent 
    {
        public int Ticks;

        public TicksCooldownComponent(int ticks)
        {
            Ticks = ticks;
        }
    }

    internal class TickCounterSystem : IExecuteSystem{
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _group;
        public TickCounterSystem(GameContext context)
        {
            _context = context;
            _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasTicksCooldown));
        }
        public void Execute() {
            var entities = _group.GetEntities();
            for (var i = 0; i<entities.Length; i++) {
                var entity = entities[i];
                entity.ecsGeneratorEntitasTicksCooldown.Ticks -= 1;
                if (entity.ecsGeneratorEntitasTicksCooldown.Ticks <= 0)
                {
                    entity.Destroy();
                }
            }
        }
    }
}