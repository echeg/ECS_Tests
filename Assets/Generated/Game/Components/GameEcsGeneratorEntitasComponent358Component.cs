//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component358 ecsGeneratorEntitasComponent358Component = new EcsGenerator.Entitas.Component358();

    public bool isEcsGeneratorEntitasComponent358 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent358); }
        set {
            if (value != isEcsGeneratorEntitasComponent358) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent358;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent358Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent358;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent358 {
        get {
            if (_matcherEcsGeneratorEntitasComponent358 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent358);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent358 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent358;
        }
    }
}