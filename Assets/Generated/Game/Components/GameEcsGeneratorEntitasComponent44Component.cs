//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component44 ecsGeneratorEntitasComponent44Component = new EcsGenerator.Entitas.Component44();

    public bool isEcsGeneratorEntitasComponent44 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent44); }
        set {
            if (value != isEcsGeneratorEntitasComponent44) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent44;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent44Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent44;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent44 {
        get {
            if (_matcherEcsGeneratorEntitasComponent44 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent44);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent44 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent44;
        }
    }
}
