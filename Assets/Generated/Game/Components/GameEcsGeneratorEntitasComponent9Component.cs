//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component9 ecsGeneratorEntitasComponent9 { get { return (EcsGenerator.Entitas.Component9)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent9); } }
    public bool hasEcsGeneratorEntitasComponent9 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent9); } }

    public void AddEcsGeneratorEntitasComponent9(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent9;
        var component = (EcsGenerator.Entitas.Component9)CreateComponent(index, typeof(EcsGenerator.Entitas.Component9));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent9(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent9;
        var component = (EcsGenerator.Entitas.Component9)CreateComponent(index, typeof(EcsGenerator.Entitas.Component9));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent9() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent9);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent9;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent9 {
        get {
            if (_matcherEcsGeneratorEntitasComponent9 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent9);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent9 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent9;
        }
    }
}
