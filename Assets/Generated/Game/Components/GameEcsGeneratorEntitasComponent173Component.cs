//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component173 ecsGeneratorEntitasComponent173 { get { return (EcsGenerator.Entitas.Component173)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent173); } }
    public bool hasEcsGeneratorEntitasComponent173 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent173); } }

    public void AddEcsGeneratorEntitasComponent173(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent173;
        var component = (EcsGenerator.Entitas.Component173)CreateComponent(index, typeof(EcsGenerator.Entitas.Component173));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent173(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent173;
        var component = (EcsGenerator.Entitas.Component173)CreateComponent(index, typeof(EcsGenerator.Entitas.Component173));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent173() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent173);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent173;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent173 {
        get {
            if (_matcherEcsGeneratorEntitasComponent173 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent173);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent173 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent173;
        }
    }
}
