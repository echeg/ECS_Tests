//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component484 ecsGeneratorEntitasComponent484 { get { return (EcsGenerator.Entitas.Component484)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent484); } }
    public bool hasEcsGeneratorEntitasComponent484 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent484); } }

    public void AddEcsGeneratorEntitasComponent484(int newField0, float newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent484;
        var component = (EcsGenerator.Entitas.Component484)CreateComponent(index, typeof(EcsGenerator.Entitas.Component484));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent484(int newField0, float newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent484;
        var component = (EcsGenerator.Entitas.Component484)CreateComponent(index, typeof(EcsGenerator.Entitas.Component484));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent484() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent484);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent484;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent484 {
        get {
            if (_matcherEcsGeneratorEntitasComponent484 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent484);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent484 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent484;
        }
    }
}
