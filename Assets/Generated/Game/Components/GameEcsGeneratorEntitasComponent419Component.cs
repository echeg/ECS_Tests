//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component419 ecsGeneratorEntitasComponent419 { get { return (EcsGenerator.Entitas.Component419)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent419); } }
    public bool hasEcsGeneratorEntitasComponent419 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent419); } }

    public void AddEcsGeneratorEntitasComponent419(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent419;
        var component = (EcsGenerator.Entitas.Component419)CreateComponent(index, typeof(EcsGenerator.Entitas.Component419));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent419(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent419;
        var component = (EcsGenerator.Entitas.Component419)CreateComponent(index, typeof(EcsGenerator.Entitas.Component419));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent419() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent419);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent419;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent419 {
        get {
            if (_matcherEcsGeneratorEntitasComponent419 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent419);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent419 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent419;
        }
    }
}