//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component143 ecsGeneratorEntitasComponent143 { get { return (EcsGenerator.Entitas.Component143)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent143); } }
    public bool hasEcsGeneratorEntitasComponent143 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent143); } }

    public void AddEcsGeneratorEntitasComponent143(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent143;
        var component = (EcsGenerator.Entitas.Component143)CreateComponent(index, typeof(EcsGenerator.Entitas.Component143));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent143(int newField0, short newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent143;
        var component = (EcsGenerator.Entitas.Component143)CreateComponent(index, typeof(EcsGenerator.Entitas.Component143));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent143() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent143);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent143;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent143 {
        get {
            if (_matcherEcsGeneratorEntitasComponent143 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent143);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent143 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent143;
        }
    }
}
