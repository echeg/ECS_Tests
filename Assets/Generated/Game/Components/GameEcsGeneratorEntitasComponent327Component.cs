//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component327 ecsGeneratorEntitasComponent327 { get { return (EcsGenerator.Entitas.Component327)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent327); } }
    public bool hasEcsGeneratorEntitasComponent327 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent327); } }

    public void AddEcsGeneratorEntitasComponent327(int newField0, short newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent327;
        var component = (EcsGenerator.Entitas.Component327)CreateComponent(index, typeof(EcsGenerator.Entitas.Component327));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent327(int newField0, short newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent327;
        var component = (EcsGenerator.Entitas.Component327)CreateComponent(index, typeof(EcsGenerator.Entitas.Component327));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent327() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent327);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent327;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent327 {
        get {
            if (_matcherEcsGeneratorEntitasComponent327 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent327);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent327 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent327;
        }
    }
}
