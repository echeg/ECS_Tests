//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component398 ecsGeneratorEntitasComponent398 { get { return (EcsGenerator.Entitas.Component398)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent398); } }
    public bool hasEcsGeneratorEntitasComponent398 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent398); } }

    public void AddEcsGeneratorEntitasComponent398(int newField0, short newField1, byte newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent398;
        var component = (EcsGenerator.Entitas.Component398)CreateComponent(index, typeof(EcsGenerator.Entitas.Component398));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent398(int newField0, short newField1, byte newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent398;
        var component = (EcsGenerator.Entitas.Component398)CreateComponent(index, typeof(EcsGenerator.Entitas.Component398));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent398() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent398);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent398;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent398 {
        get {
            if (_matcherEcsGeneratorEntitasComponent398 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent398);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent398 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent398;
        }
    }
}
