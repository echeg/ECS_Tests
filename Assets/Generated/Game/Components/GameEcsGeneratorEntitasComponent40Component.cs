//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component40 ecsGeneratorEntitasComponent40 { get { return (EcsGenerator.Entitas.Component40)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent40); } }
    public bool hasEcsGeneratorEntitasComponent40 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent40); } }

    public void AddEcsGeneratorEntitasComponent40(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent40;
        var component = (EcsGenerator.Entitas.Component40)CreateComponent(index, typeof(EcsGenerator.Entitas.Component40));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent40(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent40;
        var component = (EcsGenerator.Entitas.Component40)CreateComponent(index, typeof(EcsGenerator.Entitas.Component40));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent40() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent40);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent40;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent40 {
        get {
            if (_matcherEcsGeneratorEntitasComponent40 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent40);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent40 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent40;
        }
    }
}