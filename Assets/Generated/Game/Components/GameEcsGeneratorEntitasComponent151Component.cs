//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component151 ecsGeneratorEntitasComponent151 { get { return (EcsGenerator.Entitas.Component151)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent151); } }
    public bool hasEcsGeneratorEntitasComponent151 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent151); } }

    public void AddEcsGeneratorEntitasComponent151(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent151;
        var component = (EcsGenerator.Entitas.Component151)CreateComponent(index, typeof(EcsGenerator.Entitas.Component151));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent151(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent151;
        var component = (EcsGenerator.Entitas.Component151)CreateComponent(index, typeof(EcsGenerator.Entitas.Component151));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent151() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent151);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent151;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent151 {
        get {
            if (_matcherEcsGeneratorEntitasComponent151 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent151);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent151 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent151;
        }
    }
}
