//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component174 ecsGeneratorEntitasComponent174 { get { return (EcsGenerator.Entitas.Component174)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent174); } }
    public bool hasEcsGeneratorEntitasComponent174 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent174); } }

    public void AddEcsGeneratorEntitasComponent174(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent174;
        var component = (EcsGenerator.Entitas.Component174)CreateComponent(index, typeof(EcsGenerator.Entitas.Component174));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent174(int newField0, long newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent174;
        var component = (EcsGenerator.Entitas.Component174)CreateComponent(index, typeof(EcsGenerator.Entitas.Component174));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent174() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent174);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent174;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent174 {
        get {
            if (_matcherEcsGeneratorEntitasComponent174 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent174);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent174 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent174;
        }
    }
}
