//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component77 ecsGeneratorEntitasComponent77Component = new EcsGenerator.Entitas.Component77();

    public bool isEcsGeneratorEntitasComponent77 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent77); }
        set {
            if (value != isEcsGeneratorEntitasComponent77) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent77;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent77Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent77;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent77 {
        get {
            if (_matcherEcsGeneratorEntitasComponent77 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent77);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent77 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent77;
        }
    }
}
