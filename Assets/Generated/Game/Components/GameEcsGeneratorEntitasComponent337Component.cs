//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component337 ecsGeneratorEntitasComponent337 { get { return (EcsGenerator.Entitas.Component337)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent337); } }
    public bool hasEcsGeneratorEntitasComponent337 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent337); } }

    public void AddEcsGeneratorEntitasComponent337(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent337;
        var component = (EcsGenerator.Entitas.Component337)CreateComponent(index, typeof(EcsGenerator.Entitas.Component337));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent337(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent337;
        var component = (EcsGenerator.Entitas.Component337)CreateComponent(index, typeof(EcsGenerator.Entitas.Component337));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent337() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent337);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent337;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent337 {
        get {
            if (_matcherEcsGeneratorEntitasComponent337 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent337);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent337 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent337;
        }
    }
}
