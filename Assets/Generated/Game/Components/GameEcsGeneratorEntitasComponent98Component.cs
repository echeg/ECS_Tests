//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component98 ecsGeneratorEntitasComponent98 { get { return (EcsGenerator.Entitas.Component98)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent98); } }
    public bool hasEcsGeneratorEntitasComponent98 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent98); } }

    public void AddEcsGeneratorEntitasComponent98(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent98;
        var component = (EcsGenerator.Entitas.Component98)CreateComponent(index, typeof(EcsGenerator.Entitas.Component98));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent98(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent98;
        var component = (EcsGenerator.Entitas.Component98)CreateComponent(index, typeof(EcsGenerator.Entitas.Component98));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent98() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent98);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent98;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent98 {
        get {
            if (_matcherEcsGeneratorEntitasComponent98 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent98);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent98 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent98;
        }
    }
}