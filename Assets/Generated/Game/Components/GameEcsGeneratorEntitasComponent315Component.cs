//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component315 ecsGeneratorEntitasComponent315Component = new EcsGenerator.Entitas.Component315();

    public bool isEcsGeneratorEntitasComponent315 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent315); }
        set {
            if (value != isEcsGeneratorEntitasComponent315) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent315;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent315Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent315;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent315 {
        get {
            if (_matcherEcsGeneratorEntitasComponent315 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent315);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent315 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent315;
        }
    }
}