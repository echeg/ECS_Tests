//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsGenerator.Entitas.Component161 ecsGeneratorEntitasComponent161 { get { return (EcsGenerator.Entitas.Component161)GetComponent(GameComponentsLookup.EcsGeneratorEntitasComponent161); } }
    public bool hasEcsGeneratorEntitasComponent161 { get { return HasComponent(GameComponentsLookup.EcsGeneratorEntitasComponent161); } }

    public void AddEcsGeneratorEntitasComponent161(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent161;
        var component = (EcsGenerator.Entitas.Component161)CreateComponent(index, typeof(EcsGenerator.Entitas.Component161));
        component.Field0 = newField0;
        component.Field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsGeneratorEntitasComponent161(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsGeneratorEntitasComponent161;
        var component = (EcsGenerator.Entitas.Component161)CreateComponent(index, typeof(EcsGenerator.Entitas.Component161));
        component.Field0 = newField0;
        component.Field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsGeneratorEntitasComponent161() {
        RemoveComponent(GameComponentsLookup.EcsGeneratorEntitasComponent161);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsGeneratorEntitasComponent161;

    public static Entitas.IMatcher<GameEntity> EcsGeneratorEntitasComponent161 {
        get {
            if (_matcherEcsGeneratorEntitasComponent161 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsGeneratorEntitasComponent161);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsGeneratorEntitasComponent161 = matcher;
            }

            return _matcherEcsGeneratorEntitasComponent161;
        }
    }
}
