//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component292 ecsGeneratorEntitasComponent292 { get { return (EcsGenerator.Entitas.Component292)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent292); } }
    public bool hasEcsGeneratorEntitasComponent292 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent292); } }

    public void AddEcsGeneratorEntitasComponent292(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent292;
        var component = (EcsGenerator.Entitas.Component292)CreateComponent(index, typeof(EcsGenerator.Entitas.Component292));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent292(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent292;
        var component = (EcsGenerator.Entitas.Component292)CreateComponent(index, typeof(EcsGenerator.Entitas.Component292));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent292() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent292);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent292;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent292 {
        get {
            if (_matcherEcsGeneratorEntitasComponent292 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent292);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent292 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent292;
        }
    }
}