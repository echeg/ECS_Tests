//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component477 ecsGeneratorEntitasComponent477 { get { return (EcsGenerator.Entitas.Component477)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent477); } }
    public bool hasEcsGeneratorEntitasComponent477 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent477); } }

    public void AddEcsGeneratorEntitasComponent477(int newField0, int newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent477;
        var component = (EcsGenerator.Entitas.Component477)CreateComponent(index, typeof(EcsGenerator.Entitas.Component477));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent477(int newField0, int newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent477;
        var component = (EcsGenerator.Entitas.Component477)CreateComponent(index, typeof(EcsGenerator.Entitas.Component477));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent477() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent477);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent477;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent477 {
        get {
            if (_matcherEcsGeneratorEntitasComponent477 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent477);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent477 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent477;
        }
    }
}
