//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component421 ecsGeneratorEntitasComponent421 { get { return (EcsGenerator.Entitas.Component421)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent421); } }
    public bool hasEcsGeneratorEntitasComponent421 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent421); } }

    public void AddEcsGeneratorEntitasComponent421(int newField0, long newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent421;
        var component = (EcsGenerator.Entitas.Component421)CreateComponent(index, typeof(EcsGenerator.Entitas.Component421));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent421(int newField0, long newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent421;
        var component = (EcsGenerator.Entitas.Component421)CreateComponent(index, typeof(EcsGenerator.Entitas.Component421));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent421() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent421);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent421;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent421 {
        get {
            if (_matcherEcsGeneratorEntitasComponent421 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent421);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent421 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent421;
        }
    }
}
