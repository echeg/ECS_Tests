//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component370 ecsGeneratorEntitasComponent370Component = new EcsGenerator.Entitas.Component370();

    public bool isEcsGeneratorEntitasComponent370 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent370); }
        set {
            if (value != isEcsGeneratorEntitasComponent370) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent370;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent370Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent370;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent370 {
        get {
            if (_matcherEcsGeneratorEntitasComponent370 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent370);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent370 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent370;
        }
    }
}
