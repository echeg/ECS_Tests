//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component458 ecsGeneratorEntitasComponent458 { get { return (EcsGenerator.Entitas.Component458)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent458); } }
    public bool hasEcsGeneratorEntitasComponent458 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent458); } }

    public void AddEcsGeneratorEntitasComponent458(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent458;
        var component = (EcsGenerator.Entitas.Component458)CreateComponent(index, typeof(EcsGenerator.Entitas.Component458));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent458(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent458;
        var component = (EcsGenerator.Entitas.Component458)CreateComponent(index, typeof(EcsGenerator.Entitas.Component458));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent458() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent458);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent458;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent458 {
        get {
            if (_matcherEcsGeneratorEntitasComponent458 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent458);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent458 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent458;
        }
    }
}
