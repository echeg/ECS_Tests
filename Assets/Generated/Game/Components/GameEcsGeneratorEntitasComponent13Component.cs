//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component13 ecsGeneratorEntitasComponent13Component = new EcsGenerator.Entitas.Component13();

    public bool isEcsGeneratorEntitasComponent13 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent13); }
        set {
            if (value != isEcsGeneratorEntitasComponent13) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent13;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent13Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent13;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent13 {
        get {
            if (_matcherEcsGeneratorEntitasComponent13 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent13);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent13 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent13;
        }
    }
}
