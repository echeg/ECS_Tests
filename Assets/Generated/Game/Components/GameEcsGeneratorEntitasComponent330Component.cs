//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component330 ecsGeneratorEntitasComponent330 { get { return (EcsGenerator.Entitas.Component330)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent330); } }
    public bool hasEcsGeneratorEntitasComponent330 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent330); } }

    public void AddEcsGeneratorEntitasComponent330(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent330;
        var component = (EcsGenerator.Entitas.Component330)CreateComponent(index, typeof(EcsGenerator.Entitas.Component330));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent330(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent330;
        var component = (EcsGenerator.Entitas.Component330)CreateComponent(index, typeof(EcsGenerator.Entitas.Component330));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent330() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent330);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent330;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent330 {
        get {
            if (_matcherEcsGeneratorEntitasComponent330 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent330);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent330 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent330;
        }
    }
}
