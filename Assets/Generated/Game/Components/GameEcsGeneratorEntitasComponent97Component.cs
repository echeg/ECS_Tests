//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component97 ecsGeneratorEntitasComponent97 { get { return (EcsGenerator.Entitas.Component97)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent97); } }
    public bool hasEcsGeneratorEntitasComponent97 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent97); } }

    public void AddEcsGeneratorEntitasComponent97(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent97;
        var component = (EcsGenerator.Entitas.Component97)CreateComponent(index, typeof(EcsGenerator.Entitas.Component97));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent97(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent97;
        var component = (EcsGenerator.Entitas.Component97)CreateComponent(index, typeof(EcsGenerator.Entitas.Component97));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent97() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent97);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent97;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent97 {
        get {
            if (_matcherEcsGeneratorEntitasComponent97 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent97);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent97 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent97;
        }
    }
}
