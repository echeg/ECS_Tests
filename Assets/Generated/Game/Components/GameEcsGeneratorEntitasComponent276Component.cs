//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component276 ecsGeneratorEntitasComponent276 { get { return (EcsGenerator.Entitas.Component276)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent276); } }
    public bool hasEcsGeneratorEntitasComponent276 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent276); } }

    public void AddEcsGeneratorEntitasComponent276(int newField0, float newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent276;
        var component = (EcsGenerator.Entitas.Component276)CreateComponent(index, typeof(EcsGenerator.Entitas.Component276));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent276(int newField0, float newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent276;
        var component = (EcsGenerator.Entitas.Component276)CreateComponent(index, typeof(EcsGenerator.Entitas.Component276));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent276() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent276);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent276;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent276 {
        get {
            if (_matcherEcsGeneratorEntitasComponent276 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent276);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent276 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent276;
        }
    }
}
