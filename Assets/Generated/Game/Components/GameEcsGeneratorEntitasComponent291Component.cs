//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component291 ecsGeneratorEntitasComponent291 { get { return (EcsGenerator.Entitas.Component291)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent291); } }
    public bool hasEcsGeneratorEntitasComponent291 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent291); } }

    public void AddEcsGeneratorEntitasComponent291(int newField0, float newField1, long newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent291;
        var component = (EcsGenerator.Entitas.Component291)CreateComponent(index, typeof(EcsGenerator.Entitas.Component291));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent291(int newField0, float newField1, long newField2, byte newField3) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent291;
        var component = (EcsGenerator.Entitas.Component291)CreateComponent(index, typeof(EcsGenerator.Entitas.Component291));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        component.Field3 = newField3;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent291() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent291);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent291;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent291 {
        get {
            if (_matcherEcsGeneratorEntitasComponent291 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent291);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent291 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent291;
        }
    }
}
