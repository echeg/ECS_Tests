//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component30 ecsGeneratorEntitasComponent30 { get { return (EcsGenerator.Entitas.Component30)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent30); } }
    public bool hasEcsGeneratorEntitasComponent30 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent30); } }

    public void AddEcsGeneratorEntitasComponent30(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent30;
        var component = (EcsGenerator.Entitas.Component30)CreateComponent(index, typeof(EcsGenerator.Entitas.Component30));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent30(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent30;
        var component = (EcsGenerator.Entitas.Component30)CreateComponent(index, typeof(EcsGenerator.Entitas.Component30));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent30() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent30);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent30;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent30 {
        get {
            if (_matcherEcsGeneratorEntitasComponent30 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent30);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent30 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent30;
        }
    }
}
