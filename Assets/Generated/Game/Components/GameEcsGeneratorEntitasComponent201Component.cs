//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component201 ecsGeneratorEntitasComponent201 { get { return (EcsGenerator.Entitas.Component201)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent201); } }
    public bool hasEcsGeneratorEntitasComponent201 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent201); } }

    public void AddEcsGeneratorEntitasComponent201(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent201;
        var component = (EcsGenerator.Entitas.Component201)CreateComponent(index, typeof(EcsGenerator.Entitas.Component201));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent201(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent201;
        var component = (EcsGenerator.Entitas.Component201)CreateComponent(index, typeof(EcsGenerator.Entitas.Component201));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent201() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent201);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent201;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent201 {
        get {
            if (_matcherEcsGeneratorEntitasComponent201 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent201);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent201 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent201;
        }
    }
}
