//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component406 ecsGeneratorEntitasComponent406Component = new EcsGenerator.Entitas.Component406();

    public bool isEcsGeneratorEntitasComponent406 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent406); }
        set {
            if (value != isEcsGeneratorEntitasComponent406) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent406;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent406Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent406;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent406 {
        get {
            if (_matcherEcsGeneratorEntitasComponent406 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent406);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent406 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent406;
        }
    }
}
