//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component151 ecsGeneratorEntitasComponent151Component = new EcsGenerator.Entitas.Component151();

    public bool isEcsGeneratorEntitasComponent151 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent151); }
        set {
            if (value != isEcsGeneratorEntitasComponent151) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent151;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent151Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent151;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent151 {
        get {
            if (_matcherEcsGeneratorEntitasComponent151 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent151);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent151 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent151;
        }
    }
}
