//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component346 ecsGeneratorEntitasComponent346Component = new EcsGenerator.Entitas.Component346();

    public bool isEcsGeneratorEntitasComponent346 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent346); }
        set {
            if (value != isEcsGeneratorEntitasComponent346) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent346;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent346Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent346;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent346 {
        get {
            if (_matcherEcsGeneratorEntitasComponent346 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent346);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent346 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent346;
        }
    }
}
