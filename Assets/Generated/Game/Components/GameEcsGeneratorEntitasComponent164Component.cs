//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component164 ecsGeneratorEntitasComponent164 { get { return (EcsGenerator.Entitas.Component164)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent164); } }
    public bool hasEcsGeneratorEntitasComponent164 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent164); } }

    public void AddEcsGeneratorEntitasComponent164(int newField0, long newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent164;
        var component = (EcsGenerator.Entitas.Component164)CreateComponent(index, typeof(EcsGenerator.Entitas.Component164));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent164(int newField0, long newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent164;
        var component = (EcsGenerator.Entitas.Component164)CreateComponent(index, typeof(EcsGenerator.Entitas.Component164));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent164() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent164);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent164;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent164 {
        get {
            if (_matcherEcsGeneratorEntitasComponent164 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent164);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent164 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent164;
        }
    }
}
