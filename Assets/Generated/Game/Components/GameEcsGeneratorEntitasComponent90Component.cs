//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component90 ecsGeneratorEntitasComponent90Component = new EcsGenerator.Entitas.Component90();

    public bool isEcsGeneratorEntitasComponent90 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent90); }
        set {
            if (value != isEcsGeneratorEntitasComponent90) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent90;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent90Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent90;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent90 {
        get {
            if (_matcherEcsGeneratorEntitasComponent90 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent90);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent90 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent90;
        }
    }
}