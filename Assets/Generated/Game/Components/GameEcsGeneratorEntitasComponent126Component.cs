//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component126 ecsGeneratorEntitasComponent126 { get { return (EcsGenerator.Entitas.Component126)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent126); } }
    public bool hasEcsGeneratorEntitasComponent126 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent126); } }

    public void AddEcsGeneratorEntitasComponent126(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent126;
        var component = (EcsGenerator.Entitas.Component126)CreateComponent(index, typeof(EcsGenerator.Entitas.Component126));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent126(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent126;
        var component = (EcsGenerator.Entitas.Component126)CreateComponent(index, typeof(EcsGenerator.Entitas.Component126));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent126() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent126);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent126;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent126 {
        get {
            if (_matcherEcsGeneratorEntitasComponent126 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent126);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent126 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent126;
        }
    }
}
