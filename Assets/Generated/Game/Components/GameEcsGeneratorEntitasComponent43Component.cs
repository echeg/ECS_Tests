//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component43 ecsGeneratorEntitasComponent43 { get { return (EcsGenerator.Entitas.Component43)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent43); } }
    public bool hasEcsGeneratorEntitasComponent43 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent43); } }

    public void AddEcsGeneratorEntitasComponent43(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent43;
        var component = (EcsGenerator.Entitas.Component43)CreateComponent(index, typeof(EcsGenerator.Entitas.Component43));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent43(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent43;
        var component = (EcsGenerator.Entitas.Component43)CreateComponent(index, typeof(EcsGenerator.Entitas.Component43));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent43() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent43);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent43;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent43 {
        get {
            if (_matcherEcsGeneratorEntitasComponent43 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent43);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent43 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent43;
        }
    }
}
