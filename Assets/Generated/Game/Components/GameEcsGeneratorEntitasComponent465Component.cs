//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component465 ecsGeneratorEntitasComponent465 { get { return (EcsGenerator.Entitas.Component465)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent465); } }
    public bool hasEcsGeneratorEntitasComponent465 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent465); } }

    public void AddEcsGeneratorEntitasComponent465(int newField0, float newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent465;
        var component = (EcsGenerator.Entitas.Component465)CreateComponent(index, typeof(EcsGenerator.Entitas.Component465));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent465(int newField0, float newField1, short newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent465;
        var component = (EcsGenerator.Entitas.Component465)CreateComponent(index, typeof(EcsGenerator.Entitas.Component465));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent465() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent465);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent465;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent465 {
        get {
            if (_matcherEcsGeneratorEntitasComponent465 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent465);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent465 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent465;
        }
    }
}
