using System;
using System.Collections.Generic;
using System.Globalization;

namespace EcsGenerator
{
    public enum PossibleComponentTypes
    {
        Int = 0,
        Long = 1,
        Short = 2,
        Byte = 3,
        Float = 4,
    }

    public enum TypeSystem
    {
        OnlyCalculate = 0,
        ComponentAddAndRemove = 1,
        CreateRemoveEntity = 2,
        HasGetComponents = 3,
    }

    [System.Serializable]
    public class DslComponent
    {
        public int Id;
        public List<PossibleComponentTypes> Fields = new List<PossibleComponentTypes>();
    }

    [System.Serializable]
    public class DslSystem
    {
        public int Id;

        public TypeSystem SystemType;
        public List<DslComponent> FiltersComponents;
        public List<DslComponent> LogicComponents;
    }

    [System.Serializable]
    public class DslEntity
    {
        public int Id;
        public List<DslComponent> Components = new List<DslComponent>();

    }
}