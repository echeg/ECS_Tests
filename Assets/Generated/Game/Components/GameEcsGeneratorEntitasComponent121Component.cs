//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component121 ecsGeneratorEntitasComponent121 { get { return (EcsGenerator.Entitas.Component121)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent121); } }
    public bool hasEcsGeneratorEntitasComponent121 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent121); } }

    public void AddEcsGeneratorEntitasComponent121(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent121;
        var component = (EcsGenerator.Entitas.Component121)CreateComponent(index, typeof(EcsGenerator.Entitas.Component121));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent121(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent121;
        var component = (EcsGenerator.Entitas.Component121)CreateComponent(index, typeof(EcsGenerator.Entitas.Component121));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent121() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent121);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent121;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent121 {
        get {
            if (_matcherEcsGeneratorEntitasComponent121 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent121);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent121 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent121;
        }
    }
}