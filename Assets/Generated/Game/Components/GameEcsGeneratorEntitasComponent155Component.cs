//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component155 ecsGeneratorEntitasComponent155 { get { return (EcsGenerator.Entitas.Component155)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent155); } }
    public bool hasEcsGeneratorEntitasComponent155 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent155); } }

    public void AddEcsGeneratorEntitasComponent155(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent155;
        var component = (EcsGenerator.Entitas.Component155)CreateComponent(index, typeof(EcsGenerator.Entitas.Component155));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent155(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent155;
        var component = (EcsGenerator.Entitas.Component155)CreateComponent(index, typeof(EcsGenerator.Entitas.Component155));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent155() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent155);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent155;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent155 {
        get {
            if (_matcherEcsGeneratorEntitasComponent155 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent155);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent155 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent155;
        }
    }
}