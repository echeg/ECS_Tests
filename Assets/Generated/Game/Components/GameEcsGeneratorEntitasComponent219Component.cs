//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component219 ecsGeneratorEntitasComponent219Component = new EcsGenerator.Entitas.Component219();

    public bool isEcsGeneratorEntitasComponent219 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent219); }
        set {
            if (value != isEcsGeneratorEntitasComponent219) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent219;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent219Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent219;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent219 {
        get {
            if (_matcherEcsGeneratorEntitasComponent219 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent219);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent219 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent219;
        }
    }
}
