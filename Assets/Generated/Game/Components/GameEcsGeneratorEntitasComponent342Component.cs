//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component342 ecsGeneratorEntitasComponent342 { get { return (EcsGenerator.Entitas.Component342)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent342); } }
    public bool hasEcsGeneratorEntitasComponent342 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent342); } }

    public void AddEcsGeneratorEntitasComponent342(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent342;
        var component = (EcsGenerator.Entitas.Component342)CreateComponent(index, typeof(EcsGenerator.Entitas.Component342));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent342(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent342;
        var component = (EcsGenerator.Entitas.Component342)CreateComponent(index, typeof(EcsGenerator.Entitas.Component342));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent342() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent342);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent342;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent342 {
        get {
            if (_matcherEcsGeneratorEntitasComponent342 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent342);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent342 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent342;
        }
    }
}