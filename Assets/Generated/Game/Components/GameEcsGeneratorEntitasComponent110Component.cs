//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component110 ecsGeneratorEntitasComponent110 { get { return (EcsGenerator.Entitas.Component110)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent110); } }
    public bool hasEcsGeneratorEntitasComponent110 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent110); } }

    public void AddEcsGeneratorEntitasComponent110(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent110;
        var component = (EcsGenerator.Entitas.Component110)CreateComponent(index, typeof(EcsGenerator.Entitas.Component110));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent110(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent110;
        var component = (EcsGenerator.Entitas.Component110)CreateComponent(index, typeof(EcsGenerator.Entitas.Component110));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent110() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent110);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent110;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent110 {
        get {
            if (_matcherEcsGeneratorEntitasComponent110 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent110);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent110 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent110;
        }
    }
}