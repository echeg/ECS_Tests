//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component407 ecsGeneratorEntitasComponent407 { get { return (EcsGenerator.Entitas.Component407)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent407); } }
    public bool hasEcsGeneratorEntitasComponent407 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent407); } }

    public void AddEcsGeneratorEntitasComponent407(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent407;
        var component = (EcsGenerator.Entitas.Component407)CreateComponent(index, typeof(EcsGenerator.Entitas.Component407));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent407(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent407;
        var component = (EcsGenerator.Entitas.Component407)CreateComponent(index, typeof(EcsGenerator.Entitas.Component407));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent407() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent407);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent407;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent407 {
        get {
            if (_matcherEcsGeneratorEntitasComponent407 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent407);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent407 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent407;
        }
    }
}
