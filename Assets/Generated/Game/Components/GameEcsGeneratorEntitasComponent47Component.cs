//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component47 ecsGeneratorEntitasComponent47Component = new EcsGenerator.Entitas.Component47();

    public bool isEcsGeneratorEntitasComponent47 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent47); }
        set {
            if (value != isEcsGeneratorEntitasComponent47) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent47;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent47Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent47;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent47 {
        get {
            if (_matcherEcsGeneratorEntitasComponent47 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent47);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent47 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent47;
        }
    }
}