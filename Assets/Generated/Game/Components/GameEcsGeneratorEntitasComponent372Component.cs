//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component372 ecsGeneratorEntitasComponent372 { get { return (EcsGenerator.Entitas.Component372)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent372); } }
    public bool hasEcsGeneratorEntitasComponent372 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent372); } }

    public void AddEcsGeneratorEntitasComponent372(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent372;
        var component = (EcsGenerator.Entitas.Component372)CreateComponent(index, typeof(EcsGenerator.Entitas.Component372));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent372(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent372;
        var component = (EcsGenerator.Entitas.Component372)CreateComponent(index, typeof(EcsGenerator.Entitas.Component372));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent372() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent372);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent372;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent372 {
        get {
            if (_matcherEcsGeneratorEntitasComponent372 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent372);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent372 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent372;
        }
    }
}
