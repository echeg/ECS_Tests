//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component32 ecsGeneratorEntitasComponent32 { get { return (EcsGenerator.Entitas.Component32)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent32); } }
    public bool hasEcsGeneratorEntitasComponent32 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent32); } }

    public void AddEcsGeneratorEntitasComponent32(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent32;
        var component = (EcsGenerator.Entitas.Component32)CreateComponent(index, typeof(EcsGenerator.Entitas.Component32));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent32(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent32;
        var component = (EcsGenerator.Entitas.Component32)CreateComponent(index, typeof(EcsGenerator.Entitas.Component32));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent32() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent32);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent32;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent32 {
        get {
            if (_matcherEcsGeneratorEntitasComponent32 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent32);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent32 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent32;
        }
    }
}
