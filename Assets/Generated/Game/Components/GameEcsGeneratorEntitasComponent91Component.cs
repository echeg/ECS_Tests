//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component91 ecsGeneratorEntitasComponent91Component = new EcsGenerator.Entitas.Component91();

    public bool isEcsGeneratorEntitasComponent91 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent91); }
        set {
            if (value != isEcsGeneratorEntitasComponent91) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent91;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent91Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent91;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent91 {
        get {
            if (_matcherEcsGeneratorEntitasComponent91 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent91);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent91 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent91;
        }
    }
}