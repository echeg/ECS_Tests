//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component193 ecsGeneratorEntitasComponent193 { get { return (EcsGenerator.Entitas.Component193)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent193); } }
    public bool hasEcsGeneratorEntitasComponent193 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent193); } }

    public void AddEcsGeneratorEntitasComponent193(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent193;
        var component = (EcsGenerator.Entitas.Component193)CreateComponent(index, typeof(EcsGenerator.Entitas.Component193));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent193(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent193;
        var component = (EcsGenerator.Entitas.Component193)CreateComponent(index, typeof(EcsGenerator.Entitas.Component193));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent193() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent193);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent193;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent193 {
        get {
            if (_matcherEcsGeneratorEntitasComponent193 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent193);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent193 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent193;
        }
    }
}
