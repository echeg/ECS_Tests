//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component50 ecsGeneratorEntitasComponent50 { get { return (EcsGenerator.Entitas.Component50)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent50); } }
    public bool hasEcsGeneratorEntitasComponent50 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent50); } }

    public void AddEcsGeneratorEntitasComponent50(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent50;
        var component = (EcsGenerator.Entitas.Component50)CreateComponent(index, typeof(EcsGenerator.Entitas.Component50));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent50(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent50;
        var component = (EcsGenerator.Entitas.Component50)CreateComponent(index, typeof(EcsGenerator.Entitas.Component50));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent50() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent50);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent50;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent50 {
        get {
            if (_matcherEcsGeneratorEntitasComponent50 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent50);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent50 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent50;
        }
    }
}
