//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component199 ecsGeneratorEntitasComponent199 { get { return (EcsGenerator.Entitas.Component199)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent199); } }
    public bool hasEcsGeneratorEntitasComponent199 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent199); } }

    public void AddEcsGeneratorEntitasComponent199(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent199;
        var component = (EcsGenerator.Entitas.Component199)CreateComponent(index, typeof(EcsGenerator.Entitas.Component199));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent199(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent199;
        var component = (EcsGenerator.Entitas.Component199)CreateComponent(index, typeof(EcsGenerator.Entitas.Component199));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent199() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent199);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent199;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent199 {
        get {
            if (_matcherEcsGeneratorEntitasComponent199 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent199);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent199 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent199;
        }
    }
}
