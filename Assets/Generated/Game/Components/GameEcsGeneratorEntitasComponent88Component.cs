//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component88 ecsGeneratorEntitasComponent88 { get { return (EcsGenerator.Entitas.Component88)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent88); } }
    public bool hasEcsGeneratorEntitasComponent88 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent88); } }

    public void AddEcsGeneratorEntitasComponent88(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent88;
        var component = (EcsGenerator.Entitas.Component88)CreateComponent(index, typeof(EcsGenerator.Entitas.Component88));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent88(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent88;
        var component = (EcsGenerator.Entitas.Component88)CreateComponent(index, typeof(EcsGenerator.Entitas.Component88));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent88() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent88);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent88;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent88 {
        get {
            if (_matcherEcsGeneratorEntitasComponent88 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent88);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent88 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent88;
        }
    }
}
