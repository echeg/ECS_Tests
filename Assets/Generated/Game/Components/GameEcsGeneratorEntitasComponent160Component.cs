//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component160 ecsGeneratorEntitasComponent160 { get { return (EcsGenerator.Entitas.Component160)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent160); } }
    public bool hasEcsGeneratorEntitasComponent160 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent160); } }

    public void AddEcsGeneratorEntitasComponent160(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent160;
        var component = (EcsGenerator.Entitas.Component160)CreateComponent(index, typeof(EcsGenerator.Entitas.Component160));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent160(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent160;
        var component = (EcsGenerator.Entitas.Component160)CreateComponent(index, typeof(EcsGenerator.Entitas.Component160));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent160() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent160);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent160;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent160 {
        get {
            if (_matcherEcsGeneratorEntitasComponent160 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent160);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent160 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent160;
        }
    }
}