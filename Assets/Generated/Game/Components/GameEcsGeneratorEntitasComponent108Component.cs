//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component108 ecsGeneratorEntitasComponent108 { get { return (EcsGenerator.Entitas.Component108)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent108); } }
    public bool hasEcsGeneratorEntitasComponent108 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent108); } }

    public void AddEcsGeneratorEntitasComponent108(int newField0, float newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent108;
        var component = (EcsGenerator.Entitas.Component108)CreateComponent(index, typeof(EcsGenerator.Entitas.Component108));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent108(int newField0, float newField1, float newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent108;
        var component = (EcsGenerator.Entitas.Component108)CreateComponent(index, typeof(EcsGenerator.Entitas.Component108));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent108() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent108);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent108;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent108 {
        get {
            if (_matcherEcsGeneratorEntitasComponent108 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent108);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent108 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent108;
        }
    }
}
