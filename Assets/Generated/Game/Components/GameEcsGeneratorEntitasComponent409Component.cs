//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component409 ecsGeneratorEntitasComponent409Component = new EcsGenerator.Entitas.Component409();

    public bool isEcsGeneratorEntitasComponent409 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent409); }
        set {
            if (value != isEcsGeneratorEntitasComponent409) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent409;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent409Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent409;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent409 {
        get {
            if (_matcherEcsGeneratorEntitasComponent409 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent409);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent409 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent409;
        }
    }
}