//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component322 ecsGeneratorEntitasComponent322 { get { return (EcsGenerator.Entitas.Component322)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent322); } }
    public bool hasEcsGeneratorEntitasComponent322 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent322); } }

    public void AddEcsGeneratorEntitasComponent322(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent322;
        var component = (EcsGenerator.Entitas.Component322)CreateComponent(index, typeof(EcsGenerator.Entitas.Component322));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent322(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent322;
        var component = (EcsGenerator.Entitas.Component322)CreateComponent(index, typeof(EcsGenerator.Entitas.Component322));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent322() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent322);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent322;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent322 {
        get {
            if (_matcherEcsGeneratorEntitasComponent322 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent322);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent322 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent322;
        }
    }
}