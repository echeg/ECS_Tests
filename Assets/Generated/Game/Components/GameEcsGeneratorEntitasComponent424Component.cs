//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component424 ecsGeneratorEntitasComponent424 { get { return (EcsGenerator.Entitas.Component424)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent424); } }
    public bool hasEcsGeneratorEntitasComponent424 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent424); } }

    public void AddEcsGeneratorEntitasComponent424(int newField0, short newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent424;
        var component = (EcsGenerator.Entitas.Component424)CreateComponent(index, typeof(EcsGenerator.Entitas.Component424));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent424(int newField0, short newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent424;
        var component = (EcsGenerator.Entitas.Component424)CreateComponent(index, typeof(EcsGenerator.Entitas.Component424));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent424() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent424);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent424;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent424 {
        get {
            if (_matcherEcsGeneratorEntitasComponent424 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent424);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent424 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent424;
        }
    }
}