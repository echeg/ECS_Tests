//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component197 ecsGeneratorEntitasComponent197Component = new EcsGenerator.Entitas.Component197();

    public bool isEcsGeneratorEntitasComponent197 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent197); }
        set {
            if (value != isEcsGeneratorEntitasComponent197) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent197;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent197Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent197;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent197 {
        get {
            if (_matcherEcsGeneratorEntitasComponent197 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent197);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent197 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent197;
        }
    }
}