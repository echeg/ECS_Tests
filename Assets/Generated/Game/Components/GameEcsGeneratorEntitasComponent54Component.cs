//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component54 ecsGeneratorEntitasComponent54 { get { return (EcsGenerator.Entitas.Component54)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent54); } }
    public bool hasEcsGeneratorEntitasComponent54 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent54); } }

    public void AddEcsGeneratorEntitasComponent54(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent54;
        var component = (EcsGenerator.Entitas.Component54)CreateComponent(index, typeof(EcsGenerator.Entitas.Component54));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent54(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent54;
        var component = (EcsGenerator.Entitas.Component54)CreateComponent(index, typeof(EcsGenerator.Entitas.Component54));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent54() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent54);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent54;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent54 {
        get {
            if (_matcherEcsGeneratorEntitasComponent54 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent54);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent54 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent54;
        }
    }
}
