//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component171 ecsGeneratorEntitasComponent171 { get { return (EcsGenerator.Entitas.Component171)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent171); } }
    public bool hasEcsGeneratorEntitasComponent171 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent171); } }

    public void AddEcsGeneratorEntitasComponent171(int newField0, int newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent171;
        var component = (EcsGenerator.Entitas.Component171)CreateComponent(index, typeof(EcsGenerator.Entitas.Component171));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent171(int newField0, int newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent171;
        var component = (EcsGenerator.Entitas.Component171)CreateComponent(index, typeof(EcsGenerator.Entitas.Component171));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent171() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent171);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent171;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent171 {
        get {
            if (_matcherEcsGeneratorEntitasComponent171 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent171);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent171 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent171;
        }
    }
}
