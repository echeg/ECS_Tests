//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component385 ecsGeneratorEntitasComponent385Component = new EcsGenerator.Entitas.Component385();

    public bool isEcsGeneratorEntitasComponent385 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent385); }
        set {
            if (value != isEcsGeneratorEntitasComponent385) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent385;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent385Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent385;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent385 {
        get {
            if (_matcherEcsGeneratorEntitasComponent385 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent385);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent385 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent385;
        }
    }
}
