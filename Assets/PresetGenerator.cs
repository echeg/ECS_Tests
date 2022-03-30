using System;
using System.Collections.Generic;
using System.Linq;
using EcsGenerator.Entitas;
using EcsGenerator.LeoEcs;
using EcsGenerator.LeoEcsLite;
using UnityEngine;
using Random = System.Random;

namespace EcsGenerator
{
    public class PresetGenerator : MonoBehaviour
    {
        [SerializeField] private int seed = 42;

        [SerializeField] private int entityCount;
        [SerializeField] private int componentsCount;

        [Tooltip("Systems with only math operations")]
        [SerializeField]
        private int changeComponentsSystemsCount;

        [Tooltip("Systems with add or remove component operations")]
        [SerializeField]
        private int addRemoveComponentsSystemsCount;
        
        [Tooltip("Systems with create entity operations")]
        [SerializeField]
        private int createEntitySystemsCount;

        [Tooltip("Systems with random Has and Get(if has) operations")]
        [SerializeField]
        private int hasGetSystemsCount;
        

        [SerializeField] private int minFieldsPerComponent;
        [SerializeField] private int maxFieldsPerComponent;

        [SerializeField] private int minComponentsPerEntity;
        [SerializeField] private int maxComponentsPerEntity;

        [SerializeField] private int minComponentsPerSystemFilter;
        [SerializeField] private int maxComponentsPerSystemFilter;
        
        [SerializeField]
        private int hasGetPerSystems;
        
        [SerializeField] private DataPreset preset;

        public void GeneratePresetData()
        {
            var r = new Random(seed);

            preset.Clear();
            CreateComponents(r);
            CreateEntities(r);
            CreateOnlyCalcSystems(r);
            CreateAddRemoveSystems(r);
            CreateEntitySystems(r);
            CreateHasGetSystems(r);
            
            Debug.Log("Generation Presets Complete");
        }

        private void CreateAddRemoveSystems(Random r)
        {
            for (int i = 0; i < addRemoveComponentsSystemsCount; i++)
            {
                var filterComponentsCount = r.Next(minComponentsPerSystemFilter, maxComponentsPerSystemFilter + 1);
                var filtersComponents = GetSubsetComponents(r, preset.components, filterComponentsCount);
                var logicComponent = GetSubsetComponents(r, preset.components, 1);
                preset.systems.Add(new DslSystem
                {
                    Id = preset.systems.Count, SystemType = TypeSystem.ComponentAddAndRemove, FiltersComponents = filtersComponents,
                    LogicComponents = logicComponent
                });
            }
        }
        
        private void CreateEntitySystems(Random r)
        {
            for (int i = 0; i < createEntitySystemsCount; i++)
            {
                var filterComponentsCount = r.Next(minComponentsPerSystemFilter, maxComponentsPerSystemFilter + 1);
                var filtersComponents = GetSubsetComponents(r, preset.components, filterComponentsCount);
                var logicComponent = GetSubsetComponents(r, preset.components,1);
                preset.systems.Add(new DslSystem
                {
                    Id = preset.systems.Count, SystemType = TypeSystem.CreateRemoveEntity, FiltersComponents = filtersComponents,
                    LogicComponents = logicComponent
                });
            }
        }

        private void CreateOnlyCalcSystems(Random r)
        {
            for (int i = 0; i < changeComponentsSystemsCount; i++)
            {
                var filterComponentsCount = r.Next(minComponentsPerSystemFilter, maxComponentsPerSystemFilter + 1);
                var filtersComponents = GetSubsetComponents(r, preset.components, filterComponentsCount);
                preset.systems.Add(new DslSystem
                    {Id = preset.systems.Count, SystemType = TypeSystem.OnlyCalculate, FiltersComponents = filtersComponents});
            }
        }
        
        private void CreateHasGetSystems(Random r)
        {
            for (int i = 0; i < hasGetSystemsCount; i++)
            {
                var filterComponentsCount = r.Next(minComponentsPerSystemFilter, maxComponentsPerSystemFilter + 1);
                var filtersComponents = GetSubsetComponents(r, preset.components, filterComponentsCount);
                var logicComponent = GetSubsetComponents(r, preset.components, hasGetPerSystems);
                preset.systems.Add(new DslSystem
                {
                    Id = preset.systems.Count, SystemType = TypeSystem.HasGetComponents, FiltersComponents = filtersComponents,
                    LogicComponents = logicComponent
                });
            }
        }

        private void CreateEntities(Random r)
        {
            for (int i = 0; i < entityCount; i++)
            {
                var componentsOnEntity = r.Next(minComponentsPerEntity, maxComponentsPerEntity + 1);
                var components = GetSubsetComponents(r, preset.components, componentsOnEntity);

                preset.entities.Add(new DslEntity {Id = i, Components = components});
            }
        }

        private void CreateComponents(Random r)
        {
            for (int i = 0; i < componentsCount; i++)
            {
                var fieldsCount = r.Next(minFieldsPerComponent, maxFieldsPerComponent + 1);
                var fields = new List<PossibleComponentTypes>();
                for (int j = 0; j < fieldsCount; j++)
                {
                    if (j == 0)
                    {
                        fields.Add(PossibleComponentTypes.Int);
                    }
                    else
                    {
                        var lastType = Enum.GetValues(typeof(PossibleComponentTypes)).Cast<PossibleComponentTypes>().Max();
                        fields.Add((PossibleComponentTypes) r.Next(0, (int) (lastType) + 1));
                    }
                }

                preset.components.Add(new DslComponent {Id = i, Fields = fields});
            }
        }

        [SerializeField] private string workPath = "";
        public void GenerateLeo()
        {
            var codeGenerator = new LeoEcsCodeGenerator(Application.dataPath + "/" + workPath + "/leoecs/", preset);
            codeGenerator.Generate();
            Debug.Log("leoecs generation complete reload editor");
        }
        
        public void GenerateLeoLite()
        {
            var codeGenerator = new LeoLiteEcsCodeGenerator(Application.dataPath + "/" + workPath + "/leoecslite/", preset);
            codeGenerator.Generate();
            Debug.Log("leoliteecs generation complete reload editor");
        }
        
        public void GenerateEntitas()
        {
            var codeGenerator = new EntitasGenerator(Application.dataPath + "/" + workPath + "/entitas/", preset);
            codeGenerator.Generate();
            Debug.Log("Entitas generation complete reload editor");
        }

        private List<DslComponent> GetSubsetComponents(Random random, IReadOnlyList<DslComponent> allComponents, int count)
        {
            var output = new List<DslComponent>();
            for (int i = 0; i < count; i++)
            {
                var component = GetRandomComponent(random, allComponents);
                if (!output.Contains(component))
                {
                    output.Add(component);
                }
            }

            return output;
        }

        private static DslComponent GetRandomComponent(Random random, IReadOnlyList<DslComponent> allComponents)
        {
            return allComponents[random.Next(allComponents.Count)];
        }
        
        public static string GetFieldType(PossibleComponentTypes t)
        {
            return t.ToString().ToLower();
        }
    }
}