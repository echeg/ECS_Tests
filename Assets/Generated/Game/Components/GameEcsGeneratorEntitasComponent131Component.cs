//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component131 ecsGeneratorEntitasComponent131 { get { return (EcsGenerator.Entitas.Component131)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent131); } }
    public bool hasEcsGeneratorEntitasComponent131 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent131); } }

    public void AddEcsGeneratorEntitasComponent131(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent131;
        var component = (EcsGenerator.Entitas.Component131)CreateComponent(index, typeof(EcsGenerator.Entitas.Component131));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent131(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent131;
        var component = (EcsGenerator.Entitas.Component131)CreateComponent(index, typeof(EcsGenerator.Entitas.Component131));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent131() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent131);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent131;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent131 {
        get {
            if (_matcherEcsGeneratorEntitasComponent131 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent131);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent131 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent131;
        }
    }
}
