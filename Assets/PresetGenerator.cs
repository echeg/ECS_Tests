using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace EcsGenerator
{
    public class PresetGenerator : MonoBehaviour
    {
        [SerializeField] int seed = 42;

        [SerializeField] int entityCount;
        [SerializeField] int componentsCount;

        [Tooltip("Systems with only math operations")]
        [SerializeField] int changeComponentsSystemsCount;

        [Tooltip("Systems with add or remove component operations")]
        [SerializeField] int addRemoveComponentsSystemsCount;

        [SerializeField] int minFieldsPerComponent;
        [SerializeField] int maxFieldsPerComponent;

        [SerializeField] int minComponentsPerEntity;
        [SerializeField] int maxComponentsPerEntity;

        [SerializeField] int minComponentsPerSystemFilter;
        [SerializeField] int maxComponentsPerSystemFilter;

        [SerializeField] DataPreset preset;

        public void GeneratePresetData()
        {
            var r = new Random(seed);

            preset.Clear();
            CreateComponents(r);
            CreateEntities(r);
            CreateOnlyCalcSystems(r);
            CreateAddRemoveSystems(r);
            
            Debug.Log("Generation Presets Complete");
        }

        private void CreateAddRemoveSystems(Random r)
        {
            for (int i = changeComponentsSystemsCount; i < addRemoveComponentsSystemsCount + changeComponentsSystemsCount; i++)
            {
                var filterComponentsCount = r.Next(minComponentsPerSystemFilter, maxComponentsPerSystemFilter + 1);
                var filtersComponents = GetSubsetComponents(r, preset.components, filterComponentsCount);
                var logicComponent = GetRandomComponent(r, preset.components);
                preset.systems.Add(new DslSystem
                {
                    Id = i, SystemType = TypeSystem.ComponentAddAndRemove, FiltersComponents = filtersComponents,
                    LogicComponent = logicComponent
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
                    {Id = i, SystemType = TypeSystem.OnlyCalculate, FiltersComponents = filtersComponents});
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

        [SerializeField] string workPath = "";
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

        List<DslComponent> GetSubsetComponents(Random random, IReadOnlyList<DslComponent> allComponents, int count)
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