//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component311 ecsGeneratorEntitasComponent311 { get { return (EcsGenerator.Entitas.Component311)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent311); } }
    public bool hasEcsGeneratorEntitasComponent311 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent311); } }

    public void AddEcsGeneratorEntitasComponent311(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent311;
        var component = (EcsGenerator.Entitas.Component311)CreateComponent(index, typeof(EcsGenerator.Entitas.Component311));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent311(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent311;
        var component = (EcsGenerator.Entitas.Component311)CreateComponent(index, typeof(EcsGenerator.Entitas.Component311));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent311() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent311);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent311;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent311 {
        get {
            if (_matcherEcsGeneratorEntitasComponent311 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent311);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent311 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent311;
        }
    }
}
