//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component368 ecsGeneratorEntitasComponent368 { get { return (EcsGenerator.Entitas.Component368)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent368); } }
    public bool hasEcsGeneratorEntitasComponent368 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent368); } }

    public void AddEcsGeneratorEntitasComponent368(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent368;
        var component = (EcsGenerator.Entitas.Component368)CreateComponent(index, typeof(EcsGenerator.Entitas.Component368));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent368(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent368;
        var component = (EcsGenerator.Entitas.Component368)CreateComponent(index, typeof(EcsGenerator.Entitas.Component368));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent368() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent368);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent368;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent368 {
        get {
            if (_matcherEcsGeneratorEntitasComponent368 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent368);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent368 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent368;
        }
    }
}
