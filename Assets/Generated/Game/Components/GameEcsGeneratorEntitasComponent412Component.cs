//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component412 ecsGeneratorEntitasComponent412 { get { return (EcsGenerator.Entitas.Component412)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent412); } }
    public bool hasEcsGeneratorEntitasComponent412 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent412); } }

    public void AddEcsGeneratorEntitasComponent412(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent412;
        var component = (EcsGenerator.Entitas.Component412)CreateComponent(index, typeof(EcsGenerator.Entitas.Component412));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent412(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent412;
        var component = (EcsGenerator.Entitas.Component412)CreateComponent(index, typeof(EcsGenerator.Entitas.Component412));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent412() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent412);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent412;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent412 {
        get {
            if (_matcherEcsGeneratorEntitasComponent412 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent412);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent412 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent412;
        }
    }
}