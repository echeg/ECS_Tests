//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component253 ecsGeneratorEntitasComponent253 { get { return (EcsGenerator.Entitas.Component253)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent253); } }
    public bool hasEcsGeneratorEntitasComponent253 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent253); } }

    public void AddEcsGeneratorEntitasComponent253(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent253;
        var component = (EcsGenerator.Entitas.Component253)CreateComponent(index, typeof(EcsGenerator.Entitas.Component253));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent253(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent253;
        var component = (EcsGenerator.Entitas.Component253)CreateComponent(index, typeof(EcsGenerator.Entitas.Component253));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent253() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent253);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent253;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent253 {
        get {
            if (_matcherEcsGeneratorEntitasComponent253 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent253);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent253 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent253;
        }
    }
}