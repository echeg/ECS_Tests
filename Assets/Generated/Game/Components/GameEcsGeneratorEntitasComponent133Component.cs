//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component133 ecsGeneratorEntitasComponent133 { get { return (EcsGenerator.Entitas.Component133)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent133); } }
    public bool hasEcsGeneratorEntitasComponent133 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent133); } }

    public void AddEcsGeneratorEntitasComponent133(int newField0, long newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent133;
        var component = (EcsGenerator.Entitas.Component133)CreateComponent(index, typeof(EcsGenerator.Entitas.Component133));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent133(int newField0, long newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent133;
        var component = (EcsGenerator.Entitas.Component133)CreateComponent(index, typeof(EcsGenerator.Entitas.Component133));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent133() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent133);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent133;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent133 {
        get {
            if (_matcherEcsGeneratorEntitasComponent133 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent133);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent133 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent133;
        }
    }
}
