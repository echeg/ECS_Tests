//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component452 ecsGeneratorEntitasComponent452 { get { return (EcsGenerator.Entitas.Component452)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent452); } }
    public bool hasEcsGeneratorEntitasComponent452 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent452); } }

    public void AddEcsGeneratorEntitasComponent452(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent452;
        var component = (EcsGenerator.Entitas.Component452)CreateComponent(index, typeof(EcsGenerator.Entitas.Component452));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent452(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent452;
        var component = (EcsGenerator.Entitas.Component452)CreateComponent(index, typeof(EcsGenerator.Entitas.Component452));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent452() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent452);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent452;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent452 {
        get {
            if (_matcherEcsGeneratorEntitasComponent452 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent452);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent452 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent452;
        }
    }
}
