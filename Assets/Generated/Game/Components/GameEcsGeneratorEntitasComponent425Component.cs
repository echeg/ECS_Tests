//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcsGenerator.Entitas.Component425 ecsGeneratorEntitasComponent425Component = new EcsGenerator.Entitas.Component425();

    public bool isEcsGeneratorEntitasComponent425 {
        get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent425); }
        set {
            if (value != isEcsGeneratorEntitasComponent425) {
                var index = GameComponentsLookup.EcsGeneratorEntitasComponent425;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ecsGeneratorEntitasComponent425Component;

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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent425;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent425 {
        get {
            if (_matcherEcsGeneratorEntitasComponent425 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent425);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent425 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent425;
        }
    }
}