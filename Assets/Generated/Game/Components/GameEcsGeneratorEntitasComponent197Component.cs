//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component197 ecsGeneratorEntitasComponent197 { get { return (EcsGenerator.Entitas.Component197)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent197); } }
    public bool hasEcsGeneratorEntitasComponent197 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent197); } }

    public void AddEcsGeneratorEntitasComponent197(int newField0, int newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent197;
        var component = (EcsGenerator.Entitas.Component197)CreateComponent(index, typeof(EcsGenerator.Entitas.Component197));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent197(int newField0, int newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent197;
        var component = (EcsGenerator.Entitas.Component197)CreateComponent(index, typeof(EcsGenerator.Entitas.Component197));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent197() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent197);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent197;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent197 {
        get {
            if (_matcherEcsGeneratorEntitasComponent197 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent197);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent197 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent197;
        }
    }
}
