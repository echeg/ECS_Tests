//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component120 ecsGeneratorEntitasComponent120 { get { return (EcsGenerator.Entitas.Component120)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent120); } }
    public bool hasEcsGeneratorEntitasComponent120 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent120); } }

    public void AddEcsGeneratorEntitasComponent120(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent120;
        var component = (EcsGenerator.Entitas.Component120)CreateComponent(index, typeof(EcsGenerator.Entitas.Component120));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent120(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent120;
        var component = (EcsGenerator.Entitas.Component120)CreateComponent(index, typeof(EcsGenerator.Entitas.Component120));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent120() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent120);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent120;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent120 {
        get {
            if (_matcherEcsGeneratorEntitasComponent120 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent120);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent120 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent120;
        }
    }
}
