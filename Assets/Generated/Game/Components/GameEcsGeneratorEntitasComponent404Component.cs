//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component404 ecsGeneratorEntitasComponent404 { get { return (EcsGenerator.Entitas.Component404)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent404); } }
    public bool hasEcsGeneratorEntitasComponent404 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent404); } }

    public void AddEcsGeneratorEntitasComponent404(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent404;
        var component = (EcsGenerator.Entitas.Component404)CreateComponent(index, typeof(EcsGenerator.Entitas.Component404));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent404(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent404;
        var component = (EcsGenerator.Entitas.Component404)CreateComponent(index, typeof(EcsGenerator.Entitas.Component404));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent404() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent404);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent404;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent404 {
        get {
            if (_matcherEcsGeneratorEntitasComponent404 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent404);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent404 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent404;
        }
    }
}
