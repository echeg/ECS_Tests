//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component445 ecsGeneratorEntitasComponent445 { get { return (EcsGenerator.Entitas.Component445)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent445); } }
    public bool hasEcsGeneratorEntitasComponent445 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent445); } }

    public void AddEcsGeneratorEntitasComponent445(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent445;
        var component = (EcsGenerator.Entitas.Component445)CreateComponent(index, typeof(EcsGenerator.Entitas.Component445));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent445(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent445;
        var component = (EcsGenerator.Entitas.Component445)CreateComponent(index, typeof(EcsGenerator.Entitas.Component445));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent445() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent445);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent445;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent445 {
        get {
            if (_matcherEcsGeneratorEntitasComponent445 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent445);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent445 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent445;
        }
    }
}
