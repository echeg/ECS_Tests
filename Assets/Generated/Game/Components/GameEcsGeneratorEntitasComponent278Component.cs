//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component278 ecsGeneratorEntitasComponent278 { get { return (EcsGenerator.Entitas.Component278)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent278); } }
    public bool hasEcsGeneratorEntitasComponent278 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent278); } }

    public void AddEcsGeneratorEntitasComponent278(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent278;
        var component = (EcsGenerator.Entitas.Component278)CreateComponent(index, typeof(EcsGenerator.Entitas.Component278));
        component.Field0 = newField0;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent278(int newField0) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent278;
        var component = (EcsGenerator.Entitas.Component278)CreateComponent(index, typeof(EcsGenerator.Entitas.Component278));
        component.Field0 = newField0;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent278() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent278);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent278;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent278 {
        get {
            if (_matcherEcsGeneratorEntitasComponent278 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent278);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent278 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent278;
        }
    }
}
