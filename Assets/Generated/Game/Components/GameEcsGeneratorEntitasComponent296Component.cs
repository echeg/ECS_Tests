//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component296 ecsGeneratorEntitasComponent296 { get { return (EcsGenerator.Entitas.Component296)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent296); } }
    public bool hasEcsGeneratorEntitasComponent296 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent296); } }

    public void AddEcsGeneratorEntitasComponent296(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent296;
        var component = (EcsGenerator.Entitas.Component296)CreateComponent(index, typeof(EcsGenerator.Entitas.Component296));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent296(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent296;
        var component = (EcsGenerator.Entitas.Component296)CreateComponent(index, typeof(EcsGenerator.Entitas.Component296));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent296() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent296);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent296;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent296 {
        get {
            if (_matcherEcsGeneratorEntitasComponent296 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent296);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent296 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent296;
        }
    }
}
