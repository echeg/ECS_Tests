//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component168 ecsGeneratorEntitasComponent168Component = new EcsGenerator.Entitas.Component168();

    public bool isEcsGeneratorEntitasComponent168 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent168); }
        set {
            if (value != isEcsGeneratorEntitasComponent168) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent168;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent168Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent168;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent168 {
        get {
            if (_matcherEcsGeneratorEntitasComponent168 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent168);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent168 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent168;
        }
    }
}
