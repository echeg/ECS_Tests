//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component145 ecsGeneratorEntitasComponent145 { get { return (EcsGenerator.Entitas.Component145)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent145); } }
    public bool hasEcsGeneratorEntitasComponent145 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent145); } }

    public void AddEcsGeneratorEntitasComponent145(int newField0, int newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent145;
        var component = (EcsGenerator.Entitas.Component145)CreateComponent(index, typeof(EcsGenerator.Entitas.Component145));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent145(int newField0, int newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent145;
        var component = (EcsGenerator.Entitas.Component145)CreateComponent(index, typeof(EcsGenerator.Entitas.Component145));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent145() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent145);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent145;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent145 {
        get {
            if (_matcherEcsGeneratorEntitasComponent145 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent145);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent145 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent145;
        }
    }
}
