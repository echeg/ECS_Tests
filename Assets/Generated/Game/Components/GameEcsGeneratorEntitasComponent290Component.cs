//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component290 ecsGeneratorEntitasComponent290 { get { return (EcsGenerator.Entitas.Component290)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent290); } }
    public bool hasEcsGeneratorEntitasComponent290 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent290); } }

    public void AddEcsGeneratorEntitasComponent290(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent290;
        var component = (EcsGenerator.Entitas.Component290)CreateComponent(index, typeof(EcsGenerator.Entitas.Component290));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent290(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent290;
        var component = (EcsGenerator.Entitas.Component290)CreateComponent(index, typeof(EcsGenerator.Entitas.Component290));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent290() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent290);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent290;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent290 {
        get {
            if (_matcherEcsGeneratorEntitasComponent290 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent290);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent290 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent290;
        }
    }
}
