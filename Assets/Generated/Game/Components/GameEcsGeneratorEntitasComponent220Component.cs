//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component220 ecsGeneratorEntitasComponent220Component = new EcsGenerator.Entitas.Component220();

    public bool isEcsGeneratorEntitasComponent220 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent220); }
        set {
            if (value != isEcsGeneratorEntitasComponent220) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent220;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent220Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent220;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent220 {
        get {
            if (_matcherEcsGeneratorEntitasComponent220 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent220);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent220 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent220;
        }
    }
}
