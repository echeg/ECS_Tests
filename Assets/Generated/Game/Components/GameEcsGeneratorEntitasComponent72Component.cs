//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component72 ecsGeneratorEntitasComponent72Component = new EcsGenerator.Entitas.Component72();

    public bool isEcsGeneratorEntitasComponent72 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent72); }
        set {
            if (value != isEcsGeneratorEntitasComponent72) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent72;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent72Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent72;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent72 {
        get {
            if (_matcherEcsGeneratorEntitasComponent72 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent72);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent72 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent72;
        }
    }
}
