//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component453 ecsGeneratorEntitasComponent453 { get { return (EcsGenerator.Entitas.Component453)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent453); } }
    public bool hasEcsGeneratorEntitasComponent453 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent453); } }

    public void AddEcsGeneratorEntitasComponent453(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent453;
        var component = (EcsGenerator.Entitas.Component453)CreateComponent(index, typeof(EcsGenerator.Entitas.Component453));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent453(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent453;
        var component = (EcsGenerator.Entitas.Component453)CreateComponent(index, typeof(EcsGenerator.Entitas.Component453));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent453() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent453);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent453;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent453 {
        get {
            if (_matcherEcsGeneratorEntitasComponent453 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent453);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent453 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent453;
        }
    }
}
