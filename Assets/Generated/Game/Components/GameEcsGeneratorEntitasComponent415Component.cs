//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component415 ecsGeneratorEntitasComponent415 { get { return (EcsGenerator.Entitas.Component415)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent415); } }
    public bool hasEcsGeneratorEntitasComponent415 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent415); } }

    public void AddEcsGeneratorEntitasComponent415(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent415;
        var component = (EcsGenerator.Entitas.Component415)CreateComponent(index, typeof(EcsGenerator.Entitas.Component415));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent415(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent415;
        var component = (EcsGenerator.Entitas.Component415)CreateComponent(index, typeof(EcsGenerator.Entitas.Component415));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent415() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent415);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent415;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent415 {
        get {
            if (_matcherEcsGeneratorEntitasComponent415 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent415);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent415 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent415;
        }
    }
}
