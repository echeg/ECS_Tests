//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component63 ecsGeneratorEntitasComponent63Component = new EcsGenerator.Entitas.Component63();

    public bool isEcsGeneratorEntitasComponent63 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent63); }
        set {
            if (value != isEcsGeneratorEntitasComponent63) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent63;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent63Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent63;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent63 {
        get {
            if (_matcherEcsGeneratorEntitasComponent63 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent63);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent63 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent63;
        }
    }
}
