//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component297 ecsGeneratorEntitasComponent297 { get { return (EcsGenerator.Entitas.Component297)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent297); } }
    public bool hasEcsGeneratorEntitasComponent297 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent297); } }

    public void AddEcsGeneratorEntitasComponent297(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent297;
        var component = (EcsGenerator.Entitas.Component297)CreateComponent(index, typeof(EcsGenerator.Entitas.Component297));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent297(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent297;
        var component = (EcsGenerator.Entitas.Component297)CreateComponent(index, typeof(EcsGenerator.Entitas.Component297));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent297() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent297);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent297;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent297 {
        get {
            if (_matcherEcsGeneratorEntitasComponent297 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent297);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent297 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent297;
        }
    }
}
