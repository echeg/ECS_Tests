//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component134 ecsGeneratorEntitasComponent134 { get { return (EcsGenerator.Entitas.Component134)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent134); } }
    public bool hasEcsGeneratorEntitasComponent134 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent134); } }

    public void AddEcsGeneratorEntitasComponent134(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent134;
        var component = (EcsGenerator.Entitas.Component134)CreateComponent(index, typeof(EcsGenerator.Entitas.Component134));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent134(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent134;
        var component = (EcsGenerator.Entitas.Component134)CreateComponent(index, typeof(EcsGenerator.Entitas.Component134));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent134() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent134);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent134;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent134 {
        get {
            if (_matcherEcsGeneratorEntitasComponent134 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent134);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent134 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent134;
        }
    }
}
