//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component182 ecsGeneratorEntitasComponent182 { get { return (EcsGenerator.Entitas.Component182)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent182); } }
    public bool hasEcsGeneratorEntitasComponent182 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent182); } }

    public void AddEcsGeneratorEntitasComponent182(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent182;
        var component = (EcsGenerator.Entitas.Component182)CreateComponent(index, typeof(EcsGenerator.Entitas.Component182));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent182(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent182;
        var component = (EcsGenerator.Entitas.Component182)CreateComponent(index, typeof(EcsGenerator.Entitas.Component182));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent182() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent182);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent182;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent182 {
        get {
            if (_matcherEcsGeneratorEntitasComponent182 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent182);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent182 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent182;
        }
    }
}
