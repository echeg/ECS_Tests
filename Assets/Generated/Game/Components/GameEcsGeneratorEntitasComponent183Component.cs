//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component183 ecsGeneratorEntitasComponent183 { get { return (EcsGenerator.Entitas.Component183)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent183); } }
    public bool hasEcsGeneratorEntitasComponent183 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent183); } }

    public void AddEcsGeneratorEntitasComponent183(int newField0, byte newField1, int newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent183;
        var component = (EcsGenerator.Entitas.Component183)CreateComponent(index, typeof(EcsGenerator.Entitas.Component183));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent183(int newField0, byte newField1, int newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent183;
        var component = (EcsGenerator.Entitas.Component183)CreateComponent(index, typeof(EcsGenerator.Entitas.Component183));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent183() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent183);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent183;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent183 {
        get {
            if (_matcherEcsGeneratorEntitasComponent183 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent183);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent183 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent183;
        }
    }
}
