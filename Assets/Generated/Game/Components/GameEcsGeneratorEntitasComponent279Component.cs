//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component279 ecsGeneratorEntitasComponent279 { get { return (EcsGenerator.Entitas.Component279)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent279); } }
    public bool hasEcsGeneratorEntitasComponent279 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent279); } }

    public void AddEcsGeneratorEntitasComponent279(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent279;
        var component = (EcsGenerator.Entitas.Component279)CreateComponent(index, typeof(EcsGenerator.Entitas.Component279));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent279(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent279;
        var component = (EcsGenerator.Entitas.Component279)CreateComponent(index, typeof(EcsGenerator.Entitas.Component279));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent279() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent279);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent279;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent279 {
        get {
            if (_matcherEcsGeneratorEntitasComponent279 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent279);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent279 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent279;
        }
    }
}
