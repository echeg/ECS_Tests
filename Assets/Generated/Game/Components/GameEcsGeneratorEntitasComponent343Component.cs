//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component343 ecsGeneratorEntitasComponent343Component = new EcsGenerator.Entitas.Component343();

    public bool isEcsGeneratorEntitasComponent343 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent343); }
        set {
            if (value != isEcsGeneratorEntitasComponent343) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent343;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent343Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent343;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent343 {
        get {
            if (_matcherEcsGeneratorEntitasComponent343 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent343);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent343 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent343;
        }
    }
}