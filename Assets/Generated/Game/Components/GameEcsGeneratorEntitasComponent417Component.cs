//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component417 ecsGeneratorEntitasComponent417Component = new EcsGenerator.Entitas.Component417();

    public bool isEcsGeneratorEntitasComponent417 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent417); }
        set {
            if (value != isEcsGeneratorEntitasComponent417) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent417;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent417Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent417;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent417 {
        get {
            if (_matcherEcsGeneratorEntitasComponent417 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent417);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent417 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent417;
        }
    }
}