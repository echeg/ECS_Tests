//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component354 ecsGeneratorEntitasComponent354 { get { return (EcsGenerator.Entitas.Component354)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent354); } }
    public bool hasEcsGeneratorEntitasComponent354 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent354); } }

    public void AddEcsGeneratorEntitasComponent354(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent354;
        var component = (EcsGenerator.Entitas.Component354)CreateComponent(index, typeof(EcsGenerator.Entitas.Component354));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent354(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent354;
        var component = (EcsGenerator.Entitas.Component354)CreateComponent(index, typeof(EcsGenerator.Entitas.Component354));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent354() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent354);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent354;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent354 {
        get {
            if (_matcherEcsGeneratorEntitasComponent354 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent354);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent354 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent354;
        }
    }
}
