//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component128 ecsGeneratorEntitasComponent128 { get { return (EcsGenerator.Entitas.Component128)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent128); } }
    public bool hasEcsGeneratorEntitasComponent128 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent128); } }

    public void AddEcsGeneratorEntitasComponent128(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent128;
        var component = (EcsGenerator.Entitas.Component128)CreateComponent(index, typeof(EcsGenerator.Entitas.Component128));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent128(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent128;
        var component = (EcsGenerator.Entitas.Component128)CreateComponent(index, typeof(EcsGenerator.Entitas.Component128));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent128() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent128);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent128;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent128 {
        get {
            if (_matcherEcsGeneratorEntitasComponent128 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent128);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent128 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent128;
        }
    }
}
