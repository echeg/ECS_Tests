//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component268 ecsGeneratorEntitasComponent268 { get { return (EcsGenerator.Entitas.Component268)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent268); } }
    public bool hasEcsGeneratorEntitasComponent268 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent268); } }

    public void AddEcsGeneratorEntitasComponent268(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent268;
        var component = (EcsGenerator.Entitas.Component268)CreateComponent(index, typeof(EcsGenerator.Entitas.Component268));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent268(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent268;
        var component = (EcsGenerator.Entitas.Component268)CreateComponent(index, typeof(EcsGenerator.Entitas.Component268));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent268() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent268);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent268;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent268 {
        get {
            if (_matcherEcsGeneratorEntitasComponent268 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent268);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent268 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent268;
        }
    }
}
