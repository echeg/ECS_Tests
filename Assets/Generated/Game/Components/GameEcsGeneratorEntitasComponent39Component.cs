//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component39 ecsGeneratorEntitasComponent39 { get { return (EcsGenerator.Entitas.Component39)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent39); } }
    public bool hasEcsGeneratorEntitasComponent39 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent39); } }

    public void AddEcsGeneratorEntitasComponent39(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent39;
        var component = (EcsGenerator.Entitas.Component39)CreateComponent(index, typeof(EcsGenerator.Entitas.Component39));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent39(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent39;
        var component = (EcsGenerator.Entitas.Component39)CreateComponent(index, typeof(EcsGenerator.Entitas.Component39));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent39() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent39);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent39;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent39 {
        get {
            if (_matcherEcsGeneratorEntitasComponent39 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent39);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent39 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent39;
        }
    }
}
