//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component61 ecsGeneratorEntitasComponent61 { get { return (EcsGenerator.Entitas.Component61)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent61); } }
    public bool hasEcsGeneratorEntitasComponent61 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent61); } }

    public void AddEcsGeneratorEntitasComponent61(int newField0, float newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent61;
        var component = (EcsGenerator.Entitas.Component61)CreateComponent(index, typeof(EcsGenerator.Entitas.Component61));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent61(int newField0, float newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent61;
        var component = (EcsGenerator.Entitas.Component61)CreateComponent(index, typeof(EcsGenerator.Entitas.Component61));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent61() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent61);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent61;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent61 {
        get {
            if (_matcherEcsGeneratorEntitasComponent61 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent61);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent61 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent61;
        }
    }
}
