//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component381 ecsGeneratorEntitasComponent381 { get { return (EcsGenerator.Entitas.Component381)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent381); } }
    public bool hasEcsGeneratorEntitasComponent381 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent381); } }

    public void AddEcsGeneratorEntitasComponent381(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent381;
        var component = (EcsGenerator.Entitas.Component381)CreateComponent(index, typeof(EcsGenerator.Entitas.Component381));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent381(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent381;
        var component = (EcsGenerator.Entitas.Component381)CreateComponent(index, typeof(EcsGenerator.Entitas.Component381));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent381() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent381);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent381;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent381 {
        get {
            if (_matcherEcsGeneratorEntitasComponent381 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent381);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent381 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent381;
        }
    }
}
