//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component1 ecsGeneratorEntitasComponent1Component = new EcsGenerator.Entitas.Component1();

    public bool isEcsGeneratorEntitasComponent1 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent1); }
        set {
            if (value != isEcsGeneratorEntitasComponent1) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent1;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent1Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent1;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent1 {
        get {
            if (_matcherEcsGeneratorEntitasComponent1 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent1);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent1 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent1;
        }
    }
}