//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component284 ecsGeneratorEntitasComponent284 { get { return (EcsGenerator.Entitas.Component284)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent284); } }
    public bool hasEcsGeneratorEntitasComponent284 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent284); } }

    public void AddEcsGeneratorEntitasComponent284(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent284;
        var component = (EcsGenerator.Entitas.Component284)CreateComponent(index, typeof(EcsGenerator.Entitas.Component284));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent284(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent284;
        var component = (EcsGenerator.Entitas.Component284)CreateComponent(index, typeof(EcsGenerator.Entitas.Component284));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent284() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent284);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent284;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent284 {
        get {
            if (_matcherEcsGeneratorEntitasComponent284 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent284);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent284 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent284;
        }
    }
}