//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component194 ecsGeneratorEntitasComponent194 { get { return (EcsGenerator.Entitas.Component194)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent194); } }
    public bool hasEcsGeneratorEntitasComponent194 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent194); } }

    public void AddEcsGeneratorEntitasComponent194(int newField0, short newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent194;
        var component = (EcsGenerator.Entitas.Component194)CreateComponent(index, typeof(EcsGenerator.Entitas.Component194));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent194(int newField0, short newField1, long newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent194;
        var component = (EcsGenerator.Entitas.Component194)CreateComponent(index, typeof(EcsGenerator.Entitas.Component194));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent194() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent194);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent194;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent194 {
        get {
            if (_matcherEcsGeneratorEntitasComponent194 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent194);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent194 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent194;
        }
    }
}
