//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component111 ecsGeneratorEntitasComponent111 { get { return (EcsGenerator.Entitas.Component111)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent111); } }
    public bool hasEcsGeneratorEntitasComponent111 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent111); } }

    public void AddEcsGeneratorEntitasComponent111(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent111;
        var component = (EcsGenerator.Entitas.Component111)CreateComponent(index, typeof(EcsGenerator.Entitas.Component111));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent111(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent111;
        var component = (EcsGenerator.Entitas.Component111)CreateComponent(index, typeof(EcsGenerator.Entitas.Component111));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent111() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent111);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent111;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent111 {
        get {
            if (_matcherEcsGeneratorEntitasComponent111 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent111);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent111 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent111;
        }
    }
}
