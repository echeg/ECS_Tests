//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component434 ecsGeneratorEntitasComponent434 { get { return (EcsGenerator.Entitas.Component434)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent434); } }
    public bool hasEcsGeneratorEntitasComponent434 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent434); } }

    public void AddEcsGeneratorEntitasComponent434(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent434;
        var component = (EcsGenerator.Entitas.Component434)CreateComponent(index, typeof(EcsGenerator.Entitas.Component434));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent434(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent434;
        var component = (EcsGenerator.Entitas.Component434)CreateComponent(index, typeof(EcsGenerator.Entitas.Component434));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent434() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent434);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent434;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent434 {
        get {
            if (_matcherEcsGeneratorEntitasComponent434 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent434);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent434 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent434;
        }
    }
}
