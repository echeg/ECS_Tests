//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component258 ecsGeneratorEntitasComponent258 { get { return (EcsGenerator.Entitas.Component258)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent258); } }
    public bool hasEcsGeneratorEntitasComponent258 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent258); } }

    public void AddEcsGeneratorEntitasComponent258(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent258;
        var component = (EcsGenerator.Entitas.Component258)CreateComponent(index, typeof(EcsGenerator.Entitas.Component258));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent258(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent258;
        var component = (EcsGenerator.Entitas.Component258)CreateComponent(index, typeof(EcsGenerator.Entitas.Component258));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent258() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent258);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent258;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent258 {
        get {
            if (_matcherEcsGeneratorEntitasComponent258 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent258);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent258 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent258;
        }
    }
}
