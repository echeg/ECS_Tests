//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component93 ecsGeneratorEntitasComponent93 { get { return (EcsGenerator.Entitas.Component93)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent93); } }
    public bool hasEcsGeneratorEntitasComponent93 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent93); } }

    public void AddEcsGeneratorEntitasComponent93(int newField0, float newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent93;
        var component = (EcsGenerator.Entitas.Component93)CreateComponent(index, typeof(EcsGenerator.Entitas.Component93));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent93(int newField0, float newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent93;
        var component = (EcsGenerator.Entitas.Component93)CreateComponent(index, typeof(EcsGenerator.Entitas.Component93));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent93() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent93);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent93;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent93 {
        get {
            if (_matcherEcsGeneratorEntitasComponent93 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent93);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent93 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent93;
        }
    }
}