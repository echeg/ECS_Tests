//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component301 ecsGeneratorEntitasComponent301 { get { return (EcsGenerator.Entitas.Component301)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent301); } }
    public bool hasEcsGeneratorEntitasComponent301 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent301); } }

    public void AddEcsGeneratorEntitasComponent301(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent301;
        var component = (EcsGenerator.Entitas.Component301)CreateComponent(index, typeof(EcsGenerator.Entitas.Component301));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent301(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent301;
        var component = (EcsGenerator.Entitas.Component301)CreateComponent(index, typeof(EcsGenerator.Entitas.Component301));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent301() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent301);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent301;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent301 {
        get {
            if (_matcherEcsGeneratorEntitasComponent301 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent301);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent301 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent301;
        }
    }
}
