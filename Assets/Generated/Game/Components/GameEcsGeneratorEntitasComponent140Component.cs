//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component140 ecsGeneratorEntitasComponent140 { get { return (EcsGenerator.Entitas.Component140)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent140); } }
    public bool hasEcsGeneratorEntitasComponent140 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent140); } }

    public void AddEcsGeneratorEntitasComponent140(int newField0, int newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent140;
        var component = (EcsGenerator.Entitas.Component140)CreateComponent(index, typeof(EcsGenerator.Entitas.Component140));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent140(int newField0, int newField1, byte newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent140;
        var component = (EcsGenerator.Entitas.Component140)CreateComponent(index, typeof(EcsGenerator.Entitas.Component140));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent140() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent140);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent140;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent140 {
        get {
            if (_matcherEcsGeneratorEntitasComponent140 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent140);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent140 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent140;
        }
    }
}
