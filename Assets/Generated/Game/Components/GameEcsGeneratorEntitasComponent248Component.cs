//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component248 ecsGeneratorEntitasComponent248Component = new EcsGenerator.Entitas.Component248();

    public bool isEcsGeneratorEntitasComponent248 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent248); }
        set {
            if (value != isEcsGeneratorEntitasComponent248) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent248;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent248Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent248;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent248 {
        get {
            if (_matcherEcsGeneratorEntitasComponent248 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent248);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent248 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent248;
        }
    }
}
