//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component475 ecsGeneratorEntitasComponent475 { get { return (EcsGenerator.Entitas.Component475)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent475); } }
    public bool hasEcsGeneratorEntitasComponent475 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent475); } }

    public void AddEcsGeneratorEntitasComponent475(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent475;
        var component = (EcsGenerator.Entitas.Component475)CreateComponent(index, typeof(EcsGenerator.Entitas.Component475));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent475(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent475;
        var component = (EcsGenerator.Entitas.Component475)CreateComponent(index, typeof(EcsGenerator.Entitas.Component475));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent475() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent475);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent475;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent475 {
        get {
            if (_matcherEcsGeneratorEntitasComponent475 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent475);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent475 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent475;
        }
    }
}
