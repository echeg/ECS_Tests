//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component316 ecsGeneratorEntitasComponent316Component = new EcsGenerator.Entitas.Component316();

    public bool isEcsGeneratorEntitasComponent316 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent316); }
        set {
            if (value != isEcsGeneratorEntitasComponent316) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent316;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent316Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent316;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent316 {
        get {
            if (_matcherEcsGeneratorEntitasComponent316 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent316);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent316 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent316;
        }
    }
}
