//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component221 ecsGeneratorEntitasComponent221 { get { return (EcsGenerator.Entitas.Component221)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent221); } }
    public bool hasEcsGeneratorEntitasComponent221 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent221); } }

    public void AddEcsGeneratorEntitasComponent221(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent221;
        var component = (EcsGenerator.Entitas.Component221)CreateComponent(index, typeof(EcsGenerator.Entitas.Component221));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent221(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent221;
        var component = (EcsGenerator.Entitas.Component221)CreateComponent(index, typeof(EcsGenerator.Entitas.Component221));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent221() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent221);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent221;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent221 {
        get {
            if (_matcherEcsGeneratorEntitasComponent221 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent221);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent221 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent221;
        }
    }
}