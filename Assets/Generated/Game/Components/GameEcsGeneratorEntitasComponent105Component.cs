//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component105 ecsGeneratorEntitasComponent105 { get { return (EcsGenerator.Entitas.Component105)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent105); } }
    public bool hasEcsGeneratorEntitasComponent105 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent105); } }

    public void AddEcsGeneratorEntitasComponent105(int newField0, byte newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent105;
        var component = (EcsGenerator.Entitas.Component105)CreateComponent(index, typeof(EcsGenerator.Entitas.Component105));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent105(int newField0, byte newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent105;
        var component = (EcsGenerator.Entitas.Component105)CreateComponent(index, typeof(EcsGenerator.Entitas.Component105));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent105() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent105);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent105;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent105 {
        get {
            if (_matcherEcsGeneratorEntitasComponent105 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent105);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent105 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent105;
        }
    }
}