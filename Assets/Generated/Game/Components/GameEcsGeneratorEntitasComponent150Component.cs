//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component150 ecsGeneratorEntitasComponent150 { get { return (EcsGenerator.Entitas.Component150)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent150); } }
    public bool hasEcsGeneratorEntitasComponent150 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent150); } }

    public void AddEcsGeneratorEntitasComponent150(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent150;
        var component = (EcsGenerator.Entitas.Component150)CreateComponent(index, typeof(EcsGenerator.Entitas.Component150));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent150(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent150;
        var component = (EcsGenerator.Entitas.Component150)CreateComponent(index, typeof(EcsGenerator.Entitas.Component150));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent150() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent150);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent150;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent150 {
        get {
            if (_matcherEcsGeneratorEntitasComponent150 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent150);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent150 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent150;
        }
    }
}
