//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component59 ecsGeneratorEntitasComponent59 { get { return (EcsGenerator.Entitas.Component59)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent59); } }
    public bool hasEcsGeneratorEntitasComponent59 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent59); } }

    public void AddEcsGeneratorEntitasComponent59(int newField0, int newField1, long newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent59;
        var component = (EcsGenerator.Entitas.Component59)CreateComponent(index, typeof(EcsGenerator.Entitas.Component59));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent59(int newField0, int newField1, long newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent59;
        var component = (EcsGenerator.Entitas.Component59)CreateComponent(index, typeof(EcsGenerator.Entitas.Component59));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent59() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent59);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent59;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent59 {
        get {
            if (_matcherEcsGeneratorEntitasComponent59 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent59);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent59 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent59;
        }
    }
}
