//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component472 ecsGeneratorEntitasComponent472 { get { return (EcsGenerator.Entitas.Component472)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent472); } }
    public bool hasEcsGeneratorEntitasComponent472 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent472); } }

    public void AddEcsGeneratorEntitasComponent472(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent472;
        var component = (EcsGenerator.Entitas.Component472)CreateComponent(index, typeof(EcsGenerator.Entitas.Component472));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent472(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent472;
        var component = (EcsGenerator.Entitas.Component472)CreateComponent(index, typeof(EcsGenerator.Entitas.Component472));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent472() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent472);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent472;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent472 {
        get {
            if (_matcherEcsGeneratorEntitasComponent472 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent472);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent472 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent472;
        }
    }
}
