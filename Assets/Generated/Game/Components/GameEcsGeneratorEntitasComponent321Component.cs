//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component321 ecsGeneratorEntitasComponent321Component = new EcsGenerator.Entitas.Component321();

    public bool isEcsGeneratorEntitasComponent321 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent321); }
        set {
            if (value != isEcsGeneratorEntitasComponent321) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent321;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent321Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent321;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent321 {
        get {
            if (_matcherEcsGeneratorEntitasComponent321 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent321);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent321 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent321;
        }
    }
}
