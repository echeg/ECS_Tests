//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component28 ecsGeneratorEntitasComponent28 { get { return (EcsGenerator.Entitas.Component28)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent28); } }
    public bool hasEcsGeneratorEntitasComponent28 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent28); } }

    public void AddEcsGeneratorEntitasComponent28(int newField0, byte newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent28;
        var component = (EcsGenerator.Entitas.Component28)CreateComponent(index, typeof(EcsGenerator.Entitas.Component28));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent28(int newField0, byte newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent28;
        var component = (EcsGenerator.Entitas.Component28)CreateComponent(index, typeof(EcsGenerator.Entitas.Component28));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent28() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent28);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent28;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent28 {
        get {
            if (_matcherEcsGeneratorEntitasComponent28 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent28);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent28 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent28;
        }
    }
}