//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component392 ecsGeneratorEntitasComponent392 { get { return (EcsGenerator.Entitas.Component392)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent392); } }
    public bool hasEcsGeneratorEntitasComponent392 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent392); } }

    public void AddEcsGeneratorEntitasComponent392(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent392;
        var component = (EcsGenerator.Entitas.Component392)CreateComponent(index, typeof(EcsGenerator.Entitas.Component392));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent392(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent392;
        var component = (EcsGenerator.Entitas.Component392)CreateComponent(index, typeof(EcsGenerator.Entitas.Component392));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent392() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent392);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent392;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent392 {
        get {
            if (_matcherEcsGeneratorEntitasComponent392 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent392);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent392 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent392;
        }
    }
}
