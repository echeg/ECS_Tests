//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component467 ecsGeneratorEntitasComponent467Component = new EcsGenerator.Entitas.Component467();

    public bool isEcsGeneratorEntitasComponent467 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent467); }
        set {
            if (value != isEcsGeneratorEntitasComponent467) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent467;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent467Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent467;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent467 {
        get {
            if (_matcherEcsGeneratorEntitasComponent467 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent467);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent467 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent467;
        }
    }
}
