//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component25 ecsGeneratorEntitasComponent25 { get { return (EcsGenerator.Entitas.Component25)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent25); } }
    public bool hasEcsGeneratorEntitasComponent25 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent25); } }

    public void AddEcsGeneratorEntitasComponent25(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent25;
        var component = (EcsGenerator.Entitas.Component25)CreateComponent(index, typeof(EcsGenerator.Entitas.Component25));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent25(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent25;
        var component = (EcsGenerator.Entitas.Component25)CreateComponent(index, typeof(EcsGenerator.Entitas.Component25));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent25() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent25);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent25;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent25 {
        get {
            if (_matcherEcsGeneratorEntitasComponent25 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent25);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent25 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent25;
        }
    }
}
