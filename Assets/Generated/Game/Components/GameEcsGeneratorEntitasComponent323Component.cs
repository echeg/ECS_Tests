//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component323 ecsGeneratorEntitasComponent323 { get { return (EcsGenerator.Entitas.Component323)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent323); } }
    public bool hasEcsGeneratorEntitasComponent323 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent323); } }

    public void AddEcsGeneratorEntitasComponent323(int newField0, short newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent323;
        var component = (EcsGenerator.Entitas.Component323)CreateComponent(index, typeof(EcsGenerator.Entitas.Component323));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent323(int newField0, short newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent323;
        var component = (EcsGenerator.Entitas.Component323)CreateComponent(index, typeof(EcsGenerator.Entitas.Component323));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent323() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent323);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent323;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent323 {
        get {
            if (_matcherEcsGeneratorEntitasComponent323 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent323);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent323 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent323;
        }
    }
}
