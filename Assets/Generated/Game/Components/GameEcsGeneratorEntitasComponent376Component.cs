//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component376 ecsGeneratorEntitasComponent376 { get { return (EcsGenerator.Entitas.Component376)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent376); } }
    public bool hasEcsGeneratorEntitasComponent376 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent376); } }

    public void AddEcsGeneratorEntitasComponent376(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent376;
        var component = (EcsGenerator.Entitas.Component376)CreateComponent(index, typeof(EcsGenerator.Entitas.Component376));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent376(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent376;
        var component = (EcsGenerator.Entitas.Component376)CreateComponent(index, typeof(EcsGenerator.Entitas.Component376));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent376() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent376);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent376;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent376 {
        get {
            if (_matcherEcsGeneratorEntitasComponent376 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent376);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent376 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent376;
        }
    }
}