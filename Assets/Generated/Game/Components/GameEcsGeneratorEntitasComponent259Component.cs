//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component259 ecsGeneratorEntitasComponent259 { get { return (EcsGenerator.Entitas.Component259)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent259); } }
    public bool hasEcsGeneratorEntitasComponent259 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent259); } }

    public void AddEcsGeneratorEntitasComponent259(int newField0, float newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent259;
        var component = (EcsGenerator.Entitas.Component259)CreateComponent(index, typeof(EcsGenerator.Entitas.Component259));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent259(int newField0, float newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent259;
        var component = (EcsGenerator.Entitas.Component259)CreateComponent(index, typeof(EcsGenerator.Entitas.Component259));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent259() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent259);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent259;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent259 {
        get {
            if (_matcherEcsGeneratorEntitasComponent259 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent259);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent259 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent259;
        }
    }
}
