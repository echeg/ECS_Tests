//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component479 ecsGeneratorEntitasComponent479 { get { return (EcsGenerator.Entitas.Component479)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent479); } }
    public bool hasEcsGeneratorEntitasComponent479 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent479); } }

    public void AddEcsGeneratorEntitasComponent479(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent479;
        var component = (EcsGenerator.Entitas.Component479)CreateComponent(index, typeof(EcsGenerator.Entitas.Component479));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent479(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent479;
        var component = (EcsGenerator.Entitas.Component479)CreateComponent(index, typeof(EcsGenerator.Entitas.Component479));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent479() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent479);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent479;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent479 {
        get {
            if (_matcherEcsGeneratorEntitasComponent479 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent479);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent479 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent479;
        }
    }
}
