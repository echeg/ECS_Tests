//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component204 ecsGeneratorEntitasComponent204Component = new EcsGenerator.Entitas.Component204();

    public bool isEcsGeneratorEntitasComponent204 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent204); }
        set {
            if (value != isEcsGeneratorEntitasComponent204) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent204;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent204Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent204;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent204 {
        get {
            if (_matcherEcsGeneratorEntitasComponent204 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent204);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent204 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent204;
        }
    }
}