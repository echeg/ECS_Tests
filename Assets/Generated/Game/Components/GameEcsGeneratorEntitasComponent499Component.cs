//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component499 ecsGeneratorEntitasComponent499 { get { return (EcsGenerator.Entitas.Component499)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent499); } }
    public bool hasEcsGeneratorEntitasComponent499 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent499); } }

    public void AddEcsGeneratorEntitasComponent499(int newField0, float newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent499;
        var component = (EcsGenerator.Entitas.Component499)CreateComponent(index, typeof(EcsGenerator.Entitas.Component499));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent499(int newField0, float newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent499;
        var component = (EcsGenerator.Entitas.Component499)CreateComponent(index, typeof(EcsGenerator.Entitas.Component499));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent499() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent499);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent499;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent499 {
        get {
            if (_matcherEcsGeneratorEntitasComponent499 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent499);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent499 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent499;
        }
    }
}
