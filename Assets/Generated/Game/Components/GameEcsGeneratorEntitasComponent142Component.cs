//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component142 ecsGeneratorEntitasComponent142 { get { return (EcsGenerator.Entitas.Component142)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent142); } }
    public bool hasEcsGeneratorEntitasComponent142 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent142); } }

    public void AddEcsGeneratorEntitasComponent142(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent142;
        var component = (EcsGenerator.Entitas.Component142)CreateComponent(index, typeof(EcsGenerator.Entitas.Component142));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent142(int newField0, long newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent142;
        var component = (EcsGenerator.Entitas.Component142)CreateComponent(index, typeof(EcsGenerator.Entitas.Component142));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent142() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent142);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent142;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent142 {
        get {
            if (_matcherEcsGeneratorEntitasComponent142 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent142);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent142 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent142;
        }
    }
}
