//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component353 ecsGeneratorEntitasComponent353 { get { return (EcsGenerator.Entitas.Component353)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent353); } }
    public bool hasEcsGeneratorEntitasComponent353 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent353); } }

    public void AddEcsGeneratorEntitasComponent353(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent353;
        var component = (EcsGenerator.Entitas.Component353)CreateComponent(index, typeof(EcsGenerator.Entitas.Component353));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent353(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent353;
        var component = (EcsGenerator.Entitas.Component353)CreateComponent(index, typeof(EcsGenerator.Entitas.Component353));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent353() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent353);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent353;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent353 {
        get {
            if (_matcherEcsGeneratorEntitasComponent353 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent353);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent353 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent353;
        }
    }
}
