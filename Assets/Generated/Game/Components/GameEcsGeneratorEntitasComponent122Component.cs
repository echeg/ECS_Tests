//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component122 ecsGeneratorEntitasComponent122 { get { return (EcsGenerator.Entitas.Component122)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent122); } }
    public bool hasEcsGeneratorEntitasComponent122 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent122); } }

    public void AddEcsGeneratorEntitasComponent122(int newField0, short newField1, byte newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent122;
        var component = (EcsGenerator.Entitas.Component122)CreateComponent(index, typeof(EcsGenerator.Entitas.Component122));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent122(int newField0, short newField1, byte newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent122;
        var component = (EcsGenerator.Entitas.Component122)CreateComponent(index, typeof(EcsGenerator.Entitas.Component122));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent122() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent122);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent122;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent122 {
        get {
            if (_matcherEcsGeneratorEntitasComponent122 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent122);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent122 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent122;
        }
    }
}
