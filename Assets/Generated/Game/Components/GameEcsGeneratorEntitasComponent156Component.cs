//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component156 ecsGeneratorEntitasComponent156 { get { return (EcsGenerator.Entitas.Component156)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent156); } }
    public bool hasEcsGeneratorEntitasComponent156 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent156); } }

    public void AddEcsGeneratorEntitasComponent156(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent156;
        var component = (EcsGenerator.Entitas.Component156)CreateComponent(index, typeof(EcsGenerator.Entitas.Component156));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent156(int newField0, short newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent156;
        var component = (EcsGenerator.Entitas.Component156)CreateComponent(index, typeof(EcsGenerator.Entitas.Component156));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent156() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent156);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent156;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent156 {
        get {
            if (_matcherEcsGeneratorEntitasComponent156 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent156);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent156 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent156;
        }
    }
}