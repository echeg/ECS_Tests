//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component389 ecsGeneratorEntitasComponent389 { get { return (EcsGenerator.Entitas.Component389)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent389); } }
    public bool hasEcsGeneratorEntitasComponent389 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent389); } }

    public void AddEcsGeneratorEntitasComponent389(int newField0, byte newField1, byte newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent389;
        var component = (EcsGenerator.Entitas.Component389)CreateComponent(index, typeof(EcsGenerator.Entitas.Component389));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent389(int newField0, byte newField1, byte newField2, int newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent389;
        var component = (EcsGenerator.Entitas.Component389)CreateComponent(index, typeof(EcsGenerator.Entitas.Component389));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent389() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent389);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent389;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent389 {
        get {
            if (_matcherEcsGeneratorEntitasComponent389 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent389);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent389 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent389;
        }
    }
}
