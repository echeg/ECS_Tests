//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component190 ecsGeneratorEntitasComponent190 { get { return (EcsGenerator.Entitas.Component190)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent190); } }
    public bool hasEcsGeneratorEntitasComponent190 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent190); } }

    public void AddEcsGeneratorEntitasComponent190(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent190;
        var component = (EcsGenerator.Entitas.Component190)CreateComponent(index, typeof(EcsGenerator.Entitas.Component190));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent190(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent190;
        var component = (EcsGenerator.Entitas.Component190)CreateComponent(index, typeof(EcsGenerator.Entitas.Component190));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent190() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent190);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent190;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent190 {
        get {
            if (_matcherEcsGeneratorEntitasComponent190 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent190);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent190 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent190;
        }
    }
}
