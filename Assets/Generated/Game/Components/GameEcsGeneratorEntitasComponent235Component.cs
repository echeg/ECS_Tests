//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component235 ecsGeneratorEntitasComponent235 { get { return (EcsGenerator.Entitas.Component235)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent235); } }
    public bool hasEcsGeneratorEntitasComponent235 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent235); } }

    public void AddEcsGeneratorEntitasComponent235(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent235;
        var component = (EcsGenerator.Entitas.Component235)CreateComponent(index, typeof(EcsGenerator.Entitas.Component235));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent235(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent235;
        var component = (EcsGenerator.Entitas.Component235)CreateComponent(index, typeof(EcsGenerator.Entitas.Component235));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent235() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent235);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent235;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent235 {
        get {
            if (_matcherEcsGeneratorEntitasComponent235 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent235);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent235 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent235;
        }
    }
}