//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component364 ecsGeneratorEntitasComponent364 { get { return (EcsGenerator.Entitas.Component364)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent364); } }
    public bool hasEcsGeneratorEntitasComponent364 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent364); } }

    public void AddEcsGeneratorEntitasComponent364(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent364;
        var component = (EcsGenerator.Entitas.Component364)CreateComponent(index, typeof(EcsGenerator.Entitas.Component364));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent364(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent364;
        var component = (EcsGenerator.Entitas.Component364)CreateComponent(index, typeof(EcsGenerator.Entitas.Component364));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent364() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent364);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent364;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent364 {
        get {
            if (_matcherEcsGeneratorEntitasComponent364 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent364);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent364 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent364;
        }
    }
}
