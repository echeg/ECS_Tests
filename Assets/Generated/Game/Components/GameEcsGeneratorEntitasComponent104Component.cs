//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component104 ecsGeneratorEntitasComponent104Component = new EcsGenerator.Entitas.Component104();

    public bool isEcsGeneratorEntitasComponent104 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent104); }
        set {
            if (value != isEcsGeneratorEntitasComponent104) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent104;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent104Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent104;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent104 {
        get {
            if (_matcherEcsGeneratorEntitasComponent104 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent104);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent104 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent104;
        }
    }
}