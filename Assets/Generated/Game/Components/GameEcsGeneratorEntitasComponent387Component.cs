//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component387 ecsGeneratorEntitasComponent387 { get { return (EcsGenerator.Entitas.Component387)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent387); } }
    public bool hasEcsGeneratorEntitasComponent387 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent387); } }

    public void AddEcsGeneratorEntitasComponent387(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent387;
        var component = (EcsGenerator.Entitas.Component387)CreateComponent(index, typeof(EcsGenerator.Entitas.Component387));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent387(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent387;
        var component = (EcsGenerator.Entitas.Component387)CreateComponent(index, typeof(EcsGenerator.Entitas.Component387));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent387() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent387);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent387;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent387 {
        get {
            if (_matcherEcsGeneratorEntitasComponent387 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent387);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent387 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent387;
        }
    }
}
