//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component41 ecsGeneratorEntitasComponent41Component = new EcsGenerator.Entitas.Component41();

    public bool isEcsGeneratorEntitasComponent41 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent41); }
        set {
            if (value != isEcsGeneratorEntitasComponent41) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent41;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent41Component;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent41;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent41 {
        get {
            if (_matcherEcsGeneratorEntitasComponent41 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent41);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent41 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent41;
        }
    }
}