//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component158 ecsGeneratorEntitasComponent158 { get { return (EcsGenerator.Entitas.Component158)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent158); } }
    public bool hasEcsGeneratorEntitasComponent158 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent158); } }

    public void AddEcsGeneratorEntitasComponent158(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent158;
        var component = (EcsGenerator.Entitas.Component158)CreateComponent(index, typeof(EcsGenerator.Entitas.Component158));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent158(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent158;
        var component = (EcsGenerator.Entitas.Component158)CreateComponent(index, typeof(EcsGenerator.Entitas.Component158));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent158() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent158);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent158;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent158 {
        get {
            if (_matcherEcsGeneratorEntitasComponent158 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent158);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent158 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent158;
        }
    }
}