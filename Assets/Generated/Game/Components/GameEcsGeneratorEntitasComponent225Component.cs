//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component225 ecsGeneratorEntitasComponent225 { get { return (EcsGenerator.Entitas.Component225)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent225); } }
    public bool hasEcsGeneratorEntitasComponent225 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent225); } }

    public void AddEcsGeneratorEntitasComponent225(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent225;
        var component = (EcsGenerator.Entitas.Component225)CreateComponent(index, typeof(EcsGenerator.Entitas.Component225));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent225(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent225;
        var component = (EcsGenerator.Entitas.Component225)CreateComponent(index, typeof(EcsGenerator.Entitas.Component225));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent225() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent225);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent225;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent225 {
        get {
            if (_matcherEcsGeneratorEntitasComponent225 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent225);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent225 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent225;
        }
    }
}
