//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component403 ecsGeneratorEntitasComponent403 { get { return (EcsGenerator.Entitas.Component403)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent403); } }
    public bool hasEcsGeneratorEntitasComponent403 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent403); } }

    public void AddEcsGeneratorEntitasComponent403(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent403;
        var component = (EcsGenerator.Entitas.Component403)CreateComponent(index, typeof(EcsGenerator.Entitas.Component403));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent403(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent403;
        var component = (EcsGenerator.Entitas.Component403)CreateComponent(index, typeof(EcsGenerator.Entitas.Component403));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent403() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent403);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent403;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent403 {
        get {
            if (_matcherEcsGeneratorEntitasComponent403 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent403);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent403 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent403;
        }
    }
}