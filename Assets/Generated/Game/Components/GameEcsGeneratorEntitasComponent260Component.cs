//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component260 ecsGeneratorEntitasComponent260 { get { return (EcsGenerator.Entitas.Component260)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent260); } }
    public bool hasEcsGeneratorEntitasComponent260 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent260); } }

    public void AddEcsGeneratorEntitasComponent260(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent260;
        var component = (EcsGenerator.Entitas.Component260)CreateComponent(index, typeof(EcsGenerator.Entitas.Component260));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent260(int newField0, short newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent260;
        var component = (EcsGenerator.Entitas.Component260)CreateComponent(index, typeof(EcsGenerator.Entitas.Component260));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent260() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent260);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent260;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent260 {
        get {
            if (_matcherEcsGeneratorEntitasComponent260 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent260);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent260 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent260;
        }
    }
}
