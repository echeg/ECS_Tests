//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component14 ecsGeneratorEntitasComponent14 { get { return (EcsGenerator.Entitas.Component14)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent14); } }
    public bool hasEcsGeneratorEntitasComponent14 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent14); } }

    public void AddEcsGeneratorEntitasComponent14(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent14;
        var component = (EcsGenerator.Entitas.Component14)CreateComponent(index, typeof(EcsGenerator.Entitas.Component14));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent14(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent14;
        var component = (EcsGenerator.Entitas.Component14)CreateComponent(index, typeof(EcsGenerator.Entitas.Component14));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent14() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent14);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent14;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent14 {
        get {
            if (_matcherEcsGeneratorEntitasComponent14 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent14);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent14 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent14;
        }
    }
}
