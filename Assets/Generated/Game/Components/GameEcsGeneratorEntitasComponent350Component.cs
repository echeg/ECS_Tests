//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component350 ecsGeneratorEntitasComponent350 { get { return (EcsGenerator.Entitas.Component350)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent350); } }
    public bool hasEcsGeneratorEntitasComponent350 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent350); } }

    public void AddEcsGeneratorEntitasComponent350(int newField0, int newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent350;
        var component = (EcsGenerator.Entitas.Component350)CreateComponent(index, typeof(EcsGenerator.Entitas.Component350));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent350(int newField0, int newField1, int newField2) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent350;
        var component = (EcsGenerator.Entitas.Component350)CreateComponent(index, typeof(EcsGenerator.Entitas.Component350));
        component.Field0 = newField0;
        component.Field1 = newField1;
        component.Field2 = newField2;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent350() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent350);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent350;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent350 {
        get {
            if (_matcherEcsGeneratorEntitasComponent350 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent350);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent350 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent350;
        }
    }
}
