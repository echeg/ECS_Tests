//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component20 ecsGeneratorEntitasComponent20 { get { return (EcsGenerator.Entitas.Component20)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent20); } }
    public bool hasEcsGeneratorEntitasComponent20 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent20); } }

    public void AddEcsGeneratorEntitasComponent20(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent20;
        var component = (EcsGenerator.Entitas.Component20)CreateComponent(index, typeof(EcsGenerator.Entitas.Component20));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent20(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent20;
        var component = (EcsGenerator.Entitas.Component20)CreateComponent(index, typeof(EcsGenerator.Entitas.Component20));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent20() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent20);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent20;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent20 {
        get {
            if (_matcherEcsGeneratorEntitasComponent20 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent20);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent20 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent20;
        }
    }
}
