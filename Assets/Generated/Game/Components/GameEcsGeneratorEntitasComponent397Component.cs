//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component397 ecsGeneratorEntitasComponent397 { get { return (EcsGenerator.Entitas.Component397)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent397); } }
    public bool hasEcsGeneratorEntitasComponent397 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent397); } }

    public void AddEcsGeneratorEntitasComponent397(int newField0, byte newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent397;
        var component = (EcsGenerator.Entitas.Component397)CreateComponent(index, typeof(EcsGenerator.Entitas.Component397));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent397(int newField0, byte newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent397;
        var component = (EcsGenerator.Entitas.Component397)CreateComponent(index, typeof(EcsGenerator.Entitas.Component397));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent397() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent397);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent397;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent397 {
        get {
            if (_matcherEcsGeneratorEntitasComponent397 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent397);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent397 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent397;
        }
    }
}