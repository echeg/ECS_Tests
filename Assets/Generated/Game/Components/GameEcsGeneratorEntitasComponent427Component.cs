//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component427 ecsGeneratorEntitasComponent427 { get { return (EcsGenerator.Entitas.Component427)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent427); } }
    public bool hasEcsGeneratorEntitasComponent427 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent427); } }

    public void AddEcsGeneratorEntitasComponent427(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent427;
        var component = (EcsGenerator.Entitas.Component427)CreateComponent(index, typeof(EcsGenerator.Entitas.Component427));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent427(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent427;
        var component = (EcsGenerator.Entitas.Component427)CreateComponent(index, typeof(EcsGenerator.Entitas.Component427));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent427() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent427);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent427;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent427 {
        get {
            if (_matcherEcsGeneratorEntitasComponent427 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent427);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent427 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent427;
        }
    }
}
