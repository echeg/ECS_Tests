//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component25 ecsGeneratorEntitasComponent25Component = new EcsGenerator.Entitas.Component25();

    public bool isEcsGeneratorEntitasComponent25 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent25); }
        set {
            if (value != isEcsGeneratorEntitasComponent25) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent25;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent25Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent25;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent25 {
        get {
            if (_matcherEcsGeneratorEntitasComponent25 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent25);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent25 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent25;
        }
    }
}
