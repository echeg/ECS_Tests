//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component239 ecsGeneratorEntitasComponent239Component = new EcsGenerator.Entitas.Component239();

    public bool isEcsGeneratorEntitasComponent239 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent239); }
        set {
            if (value != isEcsGeneratorEntitasComponent239) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent239;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent239Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent239;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent239 {
        get {
            if (_matcherEcsGeneratorEntitasComponent239 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent239);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent239 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent239;
        }
    }
}
