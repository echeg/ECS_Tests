//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component119 ecsGeneratorEntitasComponent119 { get { return (EcsGenerator.Entitas.Component119)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent119); } }
    public bool hasEcsGeneratorEntitasComponent119 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent119); } }

    public void AddEcsGeneratorEntitasComponent119(int newField0, float newField1, float newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent119;
        var component = (EcsGenerator.Entitas.Component119)CreateComponent(index, typeof(EcsGenerator.Entitas.Component119));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent119(int newField0, float newField1, float newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent119;
        var component = (EcsGenerator.Entitas.Component119)CreateComponent(index, typeof(EcsGenerator.Entitas.Component119));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent119() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent119);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent119;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent119 {
        get {
            if (_matcherEcsGeneratorEntitasComponent119 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent119);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent119 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent119;
        }
    }
}
