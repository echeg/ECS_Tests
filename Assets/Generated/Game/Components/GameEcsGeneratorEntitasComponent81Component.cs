//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component81 ecsGeneratorEntitasComponent81 { get { return (EcsGenerator.Entitas.Component81)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent81); } }
    public bool hasEcsGeneratorEntitasComponent81 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent81); } }

    public void AddEcsGeneratorEntitasComponent81(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent81;
        var component = (EcsGenerator.Entitas.Component81)CreateComponent(index, typeof(EcsGenerator.Entitas.Component81));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent81(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent81;
        var component = (EcsGenerator.Entitas.Component81)CreateComponent(index, typeof(EcsGenerator.Entitas.Component81));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent81() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent81);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent81;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent81 {
        get {
            if (_matcherEcsGeneratorEntitasComponent81 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent81);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent81 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent81;
        }
    }
}
