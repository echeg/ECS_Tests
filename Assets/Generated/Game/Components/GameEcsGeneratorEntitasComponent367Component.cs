//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component367 ecsGeneratorEntitasComponent367 { get { return (EcsGenerator.Entitas.Component367)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent367); } }
    public bool hasEcsGeneratorEntitasComponent367 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent367); } }

    public void AddEcsGeneratorEntitasComponent367(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent367;
        var component = (EcsGenerator.Entitas.Component367)CreateComponent(index, typeof(EcsGenerator.Entitas.Component367));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent367(int newField0, long newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent367;
        var component = (EcsGenerator.Entitas.Component367)CreateComponent(index, typeof(EcsGenerator.Entitas.Component367));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent367() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent367);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent367;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent367 {
        get {
            if (_matcherEcsGeneratorEntitasComponent367 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent367);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent367 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent367;
        }
    }
}
