//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component324 ecsGeneratorEntitasComponent324 { get { return (EcsGenerator.Entitas.Component324)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent324); } }
    public bool hasEcsGeneratorEntitasComponent324 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent324); } }

    public void AddEcsGeneratorEntitasComponent324(int newField0, byte newField1, float newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent324;
        var component = (EcsGenerator.Entitas.Component324)CreateComponent(index, typeof(EcsGenerator.Entitas.Component324));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent324(int newField0, byte newField1, float newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent324;
        var component = (EcsGenerator.Entitas.Component324)CreateComponent(index, typeof(EcsGenerator.Entitas.Component324));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent324() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent324);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent324;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent324 {
        get {
            if (_matcherEcsGeneratorEntitasComponent324 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent324);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent324 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent324;
        }
    }
}
