//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component428 ecsGeneratorEntitasComponent428 { get { return (EcsGenerator.Entitas.Component428)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent428); } }
    public bool hasEcsGeneratorEntitasComponent428 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent428); } }

    public void AddEcsGeneratorEntitasComponent428(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent428;
        var component = (EcsGenerator.Entitas.Component428)CreateComponent(index, typeof(EcsGenerator.Entitas.Component428));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent428(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent428;
        var component = (EcsGenerator.Entitas.Component428)CreateComponent(index, typeof(EcsGenerator.Entitas.Component428));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent428() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent428);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent428;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent428 {
        get {
            if (_matcherEcsGeneratorEntitasComponent428 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent428);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent428 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent428;
        }
    }
}