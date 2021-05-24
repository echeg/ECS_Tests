using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace EcsGenerator
{
    [CreateAssetMenu(fileName = "PresetConfig", menuName = "Echeg/PresetConfig", order = 1)]
    public class DataPreset : ScriptableObject, IEcsPresetDataProvider
    {
        public string description;
        public List<DslComponent> components = new List<DslComponent>();
        public List<DslSystem> systems = new List<DslSystem>();
        public List<DslEntity> entities = new List<DslEntity>();

        public void Clear()
        {
            components.Clear();
            systems.Clear();
            entities.Clear();
        }

        public IList<DslComponent> GetComponents()
        {
            return components;
        }

        public IList<DslSystem> GetSystems()
        {
            return systems;
        }

        public IList<DslEntity> GetEntities()
        {
            return entities;
        }
    }

    public interface IEcsPresetDataProvider
    {
        IList<DslComponent> GetComponents();
        IList<DslSystem> GetSystems();
        IList<DslEntity> GetEntities();
    }
}