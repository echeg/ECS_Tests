//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component374 ecsGeneratorEntitasComponent374Component = new EcsGenerator.Entitas.Component374();

    public bool isEcsGeneratorEntitasComponent374 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent374); }
        set {
            if (value != isEcsGeneratorEntitasComponent374) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent374;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent374Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent374;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent374 {
        get {
            if (_matcherEcsGeneratorEntitasComponent374 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent374);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent374 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent374;
        }
    }
}