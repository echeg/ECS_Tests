//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component478 ecsGeneratorEntitasComponent478 { get { return (EcsGenerator.Entitas.Component478)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent478); } }
    public bool hasEcsGeneratorEntitasComponent478 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent478); } }

    public void AddEcsGeneratorEntitasComponent478(int newField0, int newField1, long newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent478;
        var component = (EcsGenerator.Entitas.Component478)CreateComponent(index, typeof(EcsGenerator.Entitas.Component478));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent478(int newField0, int newField1, long newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent478;
        var component = (EcsGenerator.Entitas.Component478)CreateComponent(index, typeof(EcsGenerator.Entitas.Component478));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent478() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent478);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent478;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent478 {
        get {
            if (_matcherEcsGeneratorEntitasComponent478 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent478);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent478 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent478;
        }
    }
}
