//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component274 ecsGeneratorEntitasComponent274 { get { return (EcsGenerator.Entitas.Component274)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent274); } }
    public bool hasEcsGeneratorEntitasComponent274 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent274); } }

    public void AddEcsGeneratorEntitasComponent274(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent274;
        var component = (EcsGenerator.Entitas.Component274)CreateComponent(index, typeof(EcsGenerator.Entitas.Component274));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent274(int newField0, byte newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent274;
        var component = (EcsGenerator.Entitas.Component274)CreateComponent(index, typeof(EcsGenerator.Entitas.Component274));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent274() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent274);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent274;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent274 {
        get {
            if (_matcherEcsGeneratorEntitasComponent274 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent274);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent274 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent274;
        }
    }
}
