//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component53 ecsGeneratorEntitasComponent53 { get { return (EcsGenerator.Entitas.Component53)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent53); } }
    public bool hasEcsGeneratorEntitasComponent53 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent53); } }

    public void AddEcsGeneratorEntitasComponent53(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent53;
        var component = (EcsGenerator.Entitas.Component53)CreateComponent(index, typeof(EcsGenerator.Entitas.Component53));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent53(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent53;
        var component = (EcsGenerator.Entitas.Component53)CreateComponent(index, typeof(EcsGenerator.Entitas.Component53));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent53() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent53);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent53;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent53 {
        get {
            if (_matcherEcsGeneratorEntitasComponent53 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent53);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent53 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent53;
        }
    }
}
