//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component43 ecsGeneratorEntitasComponent43Component = new EcsGenerator.Entitas.Component43();

    public bool isEcsGeneratorEntitasComponent43 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent43); }
        set {
            if (value != isEcsGeneratorEntitasComponent43) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent43;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent43Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent43;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent43 {
        get {
            if (_matcherEcsGeneratorEntitasComponent43 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent43);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent43 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent43;
        }
    }
}
