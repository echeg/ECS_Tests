//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component31 ecsGeneratorEntitasComponent31Component = new EcsGenerator.Entitas.Component31();

    public bool isEcsGeneratorEntitasComponent31 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent31); }
        set {
            if (value != isEcsGeneratorEntitasComponent31) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent31;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent31Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent31;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent31 {
        get {
            if (_matcherEcsGeneratorEntitasComponent31 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent31);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent31 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent31;
        }
    }
}
