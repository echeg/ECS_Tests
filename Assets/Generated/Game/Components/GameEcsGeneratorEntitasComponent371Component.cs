//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component371 ecsGeneratorEntitasComponent371Component = new EcsGenerator.Entitas.Component371();

    public bool isEcsGeneratorEntitasComponent371 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent371); }
        set {
            if (value != isEcsGeneratorEntitasComponent371) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent371;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent371Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent371;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent371 {
        get {
            if (_matcherEcsGeneratorEntitasComponent371 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent371);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent371 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent371;
        }
    }
}
