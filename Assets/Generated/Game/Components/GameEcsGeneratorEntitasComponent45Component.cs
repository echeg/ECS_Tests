//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component45 ecsGeneratorEntitasComponent45 { get { return (EcsGenerator.Entitas.Component45)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent45); } }
    public bool hasEcsGeneratorEntitasComponent45 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent45); } }

    public void AddEcsGeneratorEntitasComponent45(int newField0, short newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent45;
        var component = (EcsGenerator.Entitas.Component45)CreateComponent(index, typeof(EcsGenerator.Entitas.Component45));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent45(int newField0, short newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent45;
        var component = (EcsGenerator.Entitas.Component45)CreateComponent(index, typeof(EcsGenerator.Entitas.Component45));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent45() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent45);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent45;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent45 {
        get {
            if (_matcherEcsGeneratorEntitasComponent45 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent45);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent45 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent45;
        }
    }
}