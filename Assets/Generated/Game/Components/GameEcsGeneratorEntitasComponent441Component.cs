//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component441 ecsGeneratorEntitasComponent441 { get { return (EcsGenerator.Entitas.Component441)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent441); } }
    public bool hasEcsGeneratorEntitasComponent441 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent441); } }

    public void AddEcsGeneratorEntitasComponent441(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent441;
        var component = (EcsGenerator.Entitas.Component441)CreateComponent(index, typeof(EcsGenerator.Entitas.Component441));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent441(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent441;
        var component = (EcsGenerator.Entitas.Component441)CreateComponent(index, typeof(EcsGenerator.Entitas.Component441));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent441() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent441);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent441;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent441 {
        get {
            if (_matcherEcsGeneratorEntitasComponent441 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent441);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent441 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent441;
        }
    }
}
