//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component465 ecsGeneratorEntitasComponent465Component = new EcsGenerator.Entitas.Component465();

    public bool isEcsGeneratorEntitasComponent465 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent465); }
        set {
            if (value != isEcsGeneratorEntitasComponent465) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent465;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent465Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent465;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent465 {
        get {
            if (_matcherEcsGeneratorEntitasComponent465 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent465);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent465 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent465;
        }
    }
}
