//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component423 ecsGeneratorEntitasComponent423 { get { return (EcsGenerator.Entitas.Component423)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent423); } }
    public bool hasEcsGeneratorEntitasComponent423 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent423); } }

    public void AddEcsGeneratorEntitasComponent423(int newField0, int newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent423;
        var component = (EcsGenerator.Entitas.Component423)CreateComponent(index, typeof(EcsGenerator.Entitas.Component423));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent423(int newField0, int newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent423;
        var component = (EcsGenerator.Entitas.Component423)CreateComponent(index, typeof(EcsGenerator.Entitas.Component423));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent423() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent423);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent423;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent423 {
        get {
            if (_matcherEcsGeneratorEntitasComponent423 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent423);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent423 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent423;
        }
    }
}
