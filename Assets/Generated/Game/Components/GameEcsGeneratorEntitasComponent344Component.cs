//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component344 ecsGeneratorEntitasComponent344Component = new EcsGenerator.Entitas.Component344();

    public bool isEcsGeneratorEntitasComponent344 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent344); }
        set {
            if (value != isEcsGeneratorEntitasComponent344) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent344;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent344Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent344;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent344 {
        get {
            if (_matcherEcsGeneratorEntitasComponent344 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent344);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent344 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent344;
        }
    }
}
