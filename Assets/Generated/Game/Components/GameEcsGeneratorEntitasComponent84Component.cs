//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component84 ecsGeneratorEntitasComponent84Component = new EcsGenerator.Entitas.Component84();

    public bool isEcsGeneratorEntitasComponent84 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent84); }
        set {
            if (value != isEcsGeneratorEntitasComponent84) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent84;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent84Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent84;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent84 {
        get {
            if (_matcherEcsGeneratorEntitasComponent84 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent84);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent84 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent84;
        }
    }
}