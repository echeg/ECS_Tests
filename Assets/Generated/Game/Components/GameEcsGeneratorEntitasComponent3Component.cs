//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component3 ecsGeneratorEntitasComponent3 { get { return (EcsGenerator.Entitas.Component3)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent3); } }
    public bool hasEcsGeneratorEntitasComponent3 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent3); } }

    public void AddEcsGeneratorEntitasComponent3(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent3;
        var component = (EcsGenerator.Entitas.Component3)CreateComponent(index, typeof(EcsGenerator.Entitas.Component3));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent3(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent3;
        var component = (EcsGenerator.Entitas.Component3)CreateComponent(index, typeof(EcsGenerator.Entitas.Component3));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent3() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent3);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent3;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent3 {
        get {
            if (_matcherEcsGeneratorEntitasComponent3 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent3);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent3 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent3;
        }
    }
}