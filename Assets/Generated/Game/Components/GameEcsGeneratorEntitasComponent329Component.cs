//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component329 ecsGeneratorEntitasComponent329 { get { return (EcsGenerator.Entitas.Component329)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent329); } }
    public bool hasEcsGeneratorEntitasComponent329 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent329); } }

    public void AddEcsGeneratorEntitasComponent329(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent329;
        var component = (EcsGenerator.Entitas.Component329)CreateComponent(index, typeof(EcsGenerator.Entitas.Component329));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent329(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent329;
        var component = (EcsGenerator.Entitas.Component329)CreateComponent(index, typeof(EcsGenerator.Entitas.Component329));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent329() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent329);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent329;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent329 {
        get {
            if (_matcherEcsGeneratorEntitasComponent329 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent329);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent329 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent329;
        }
    }
}
