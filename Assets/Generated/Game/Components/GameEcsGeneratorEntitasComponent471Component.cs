//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component471 ecsGeneratorEntitasComponent471 { get { return (EcsGenerator.Entitas.Component471)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent471); } }
    public bool hasEcsGeneratorEntitasComponent471 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent471); } }

    public void AddEcsGeneratorEntitasComponent471(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent471;
        var component = (EcsGenerator.Entitas.Component471)CreateComponent(index, typeof(EcsGenerator.Entitas.Component471));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent471(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent471;
        var component = (EcsGenerator.Entitas.Component471)CreateComponent(index, typeof(EcsGenerator.Entitas.Component471));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent471() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent471);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent471;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent471 {
        get {
            if (_matcherEcsGeneratorEntitasComponent471 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent471);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent471 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent471;
        }
    }
}
