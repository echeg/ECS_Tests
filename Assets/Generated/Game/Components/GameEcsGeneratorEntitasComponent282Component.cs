//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component282 ecsGeneratorEntitasComponent282 { get { return (EcsGenerator.Entitas.Component282)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent282); } }
    public bool hasEcsGeneratorEntitasComponent282 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent282); } }

    public void AddEcsGeneratorEntitasComponent282(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent282;
        var component = (EcsGenerator.Entitas.Component282)CreateComponent(index, typeof(EcsGenerator.Entitas.Component282));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent282(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent282;
        var component = (EcsGenerator.Entitas.Component282)CreateComponent(index, typeof(EcsGenerator.Entitas.Component282));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent282() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent282);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent282;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent282 {
        get {
            if (_matcherEcsGeneratorEntitasComponent282 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent282);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent282 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent282;
        }
    }
}