//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component152 ecsGeneratorEntitasComponent152 { get { return (EcsGenerator.Entitas.Component152)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent152); } }
    public bool hasEcsGeneratorEntitasComponent152 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent152); } }

    public void AddEcsGeneratorEntitasComponent152(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent152;
        var component = (EcsGenerator.Entitas.Component152)CreateComponent(index, typeof(EcsGenerator.Entitas.Component152));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent152(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent152;
        var component = (EcsGenerator.Entitas.Component152)CreateComponent(index, typeof(EcsGenerator.Entitas.Component152));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent152() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent152);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent152;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent152 {
        get {
            if (_matcherEcsGeneratorEntitasComponent152 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent152);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent152 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent152;
        }
    }
}
