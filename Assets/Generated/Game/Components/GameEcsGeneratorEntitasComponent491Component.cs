//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component491 ecsGeneratorEntitasComponent491 { get { return (EcsGenerator.Entitas.Component491)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent491); } }
    public bool hasEcsGeneratorEntitasComponent491 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent491); } }

    public void AddEcsGeneratorEntitasComponent491(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent491;
        var component = (EcsGenerator.Entitas.Component491)CreateComponent(index, typeof(EcsGenerator.Entitas.Component491));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent491(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent491;
        var component = (EcsGenerator.Entitas.Component491)CreateComponent(index, typeof(EcsGenerator.Entitas.Component491));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent491() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent491);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent491;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent491 {
        get {
            if (_matcherEcsGeneratorEntitasComponent491 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent491);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent491 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent491;
        }
    }
}
