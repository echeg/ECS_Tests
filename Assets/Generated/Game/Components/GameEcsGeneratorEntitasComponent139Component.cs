//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component139 ecsGeneratorEntitasComponent139 { get { return (EcsGenerator.Entitas.Component139)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent139); } }
    public bool hasEcsGeneratorEntitasComponent139 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent139); } }

    public void AddEcsGeneratorEntitasComponent139(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent139;
        var component = (EcsGenerator.Entitas.Component139)CreateComponent(index, typeof(EcsGenerator.Entitas.Component139));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent139(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent139;
        var component = (EcsGenerator.Entitas.Component139)CreateComponent(index, typeof(EcsGenerator.Entitas.Component139));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent139() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent139);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent139;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent139 {
        get {
            if (_matcherEcsGeneratorEntitasComponent139 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent139);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent139 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent139;
        }
    }
}
