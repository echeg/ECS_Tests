//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component247 ecsGeneratorEntitasComponent247Component = new EcsGenerator.Entitas.Component247();

    public bool isEcsGeneratorEntitasComponent247 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent247); }
        set {
            if (value != isEcsGeneratorEntitasComponent247) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent247;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent247Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent247;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent247 {
        get {
            if (_matcherEcsGeneratorEntitasComponent247 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent247);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent247 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent247;
        }
    }
}
