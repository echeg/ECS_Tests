//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component435 ecsGeneratorEntitasComponent435 { get { return (EcsGenerator.Entitas.Component435)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent435); } }
    public bool hasEcsGeneratorEntitasComponent435 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent435); } }

    public void AddEcsGeneratorEntitasComponent435(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent435;
        var component = (EcsGenerator.Entitas.Component435)CreateComponent(index, typeof(EcsGenerator.Entitas.Component435));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent435(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent435;
        var component = (EcsGenerator.Entitas.Component435)CreateComponent(index, typeof(EcsGenerator.Entitas.Component435));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent435() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent435);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent435;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent435 {
        get {
            if (_matcherEcsGeneratorEntitasComponent435 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent435);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent435 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent435;
        }
    }
}
