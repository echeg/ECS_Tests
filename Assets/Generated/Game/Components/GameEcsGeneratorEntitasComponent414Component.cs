//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component414 ecsGeneratorEntitasComponent414 { get { return (EcsGenerator.Entitas.Component414)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent414); } }
    public bool hasEcsGeneratorEntitasComponent414 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent414); } }

    public void AddEcsGeneratorEntitasComponent414(int newField0, float newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent414;
        var component = (EcsGenerator.Entitas.Component414)CreateComponent(index, typeof(EcsGenerator.Entitas.Component414));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent414(int newField0, float newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent414;
        var component = (EcsGenerator.Entitas.Component414)CreateComponent(index, typeof(EcsGenerator.Entitas.Component414));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent414() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent414);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent414;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent414 {
        get {
            if (_matcherEcsGeneratorEntitasComponent414 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent414);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent414 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent414;
        }
    }
}
