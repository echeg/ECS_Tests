//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component321 ecsGeneratorEntitasComponent321 { get { return (EcsGenerator.Entitas.Component321)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent321); } }
    public bool hasEcsGeneratorEntitasComponent321 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent321); } }

    public void AddEcsGeneratorEntitasComponent321(int newField0, byte newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent321;
        var component = (EcsGenerator.Entitas.Component321)CreateComponent(index, typeof(EcsGenerator.Entitas.Component321));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent321(int newField0, byte newField1, float newField2, long newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent321;
        var component = (EcsGenerator.Entitas.Component321)CreateComponent(index, typeof(EcsGenerator.Entitas.Component321));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent321() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent321);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent321;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent321 {
        get {
            if (_matcherEcsGeneratorEntitasComponent321 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent321);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent321 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent321;
        }
    }
}
