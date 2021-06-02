# ECS_Tests
Testing the performance of ECS frameworks

This repo contains benchmarks of some c# ECS frameworks. Feel free to add your own or correct usage of existing ones!
The main idea is to create tests that are somehow close to real use.
And also give the opportunity to customize them.

Tested frameworks include:
Entitas
Leopotam.Ecs
Leopotam.EcsLite

How it works:  
1 Open SampleScene in Unity3D  
2 Change settings on Prese Generator  

![image](https://user-images.githubusercontent.com/793087/119400217-87afac80-bce2-11eb-960d-b65d5ee0cd00.png)
You can create different data presets and compare them.  

3 Press Play Button
4 Press "Gen Data Preset" - for create presed data  
![image](https://user-images.githubusercontent.com/793087/119400337-b7f74b00-bce2-11eb-9ee6-0d73a36b139c.png)

5 Press "Gen LeoEcs" or "Gen Leo Lite Ecs" for generate real code.  
![image](https://user-images.githubusercontent.com/793087/119400583-0c022f80-bce3-11eb-8a27-8cd26ad9ca75.png)  
You will update the code in the Generated folder

6 Choose one of the simulation frameworks  
![image](https://user-images.githubusercontent.com/793087/119400715-3c49ce00-bce3-11eb-91ae-6dc6ccc07923.png)  

7 Run tests   
![image](https://user-images.githubusercontent.com/793087/119400791-54215200-bce3-11eb-9b85-548fa57e956f.png)  


Example Generated Components:
```
//leoecs and leolite 
public struct Component0
{
public int Field0;
public int Field1;
public int Field2;
}

// entities
[Game]
public sealed class Component0 : IComponent 
{
public int Field0;
public int Field1;
public int Field2;
}

// unity ecs
public struct Component0 : IComponentData
{
public int Field0;
public int Field1;
public int Field2;
}
```

Example Generated Systems Sum of Two

```
// leoecs
class System1 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component453,Component118,Component43> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   ref var component2 = ref _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

// leolite
class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component453> _p1;
EcsPool<Component118> _p2;
EcsPool<Component43> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component453>().Inc<Component118>().Inc<Component43>().End();
   _p1 = _world.GetPool<Component453>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}


// entitas
class System1 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System1(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent453,GameMatcher.EcsGeneratorEntitasComponent118,GameMatcher.EcsGeneratorEntitasComponent43));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = entities[i];
   var component1 = e.ecsGeneratorEntitasComponent453;
   var component2 = e.ecsGeneratorEntitasComponent118;
   component1.Field0 += component2.Field0;
  }
 }
}

// unity ecs
[AlwaysUpdateSystem]
class System1 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
Entities
.WithAll<Component43>()
.ForEach((ref Component453 c1,ref Component118 c2 ) =>{
c1.Field0 += c2.Field0;
 }).Run();
 }
}
```

System Create Entity 

```
// leoecs
class System699 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component478,Component314,Component235,Component285> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component291());
  }
 }
}

//leolite
class System699 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component478> _p1;
EcsPool<Component314> _p2;
EcsPool<Component235> _p3;
EcsPool<Component285> _p4;
EcsPool<Component291> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component478>().Inc<Component314>().Inc<Component235>().Inc<Component285>().End();
   _p1 = _world.GetPool<Component478>();
   _p2 = _world.GetPool<Component314>();
   _p3 = _world.GetPool<Component235>();
   _p4 = _world.GetPool<Component285>();
   _pl = _world.GetPool<Component291>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

//entitas
class System699 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System699(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent478,GameMatcher.EcsGeneratorEntitasComponent314,GameMatcher.EcsGeneratorEntitasComponent235,GameMatcher.EcsGeneratorEntitasComponent285));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = _context.CreateEntity();
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent291,new Component291());
  }
 }
}

// unity ecs with EntityManager 
class System699 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
Entities.WithoutBurst().WithStructuralChanges()
.WithAll<Component478,Component314,Component235>()
.ForEach((Entity e) =>{
   var e1 = _em.CreateEntity();
   _em.AddComponentData(e1, new TicksCooldownComponent(10));
  _em.AddComponentData(e1, new Component291());
 }).Run(); }
}
}

// with CommandBuffer - not same output
[AlwaysUpdateSystem]
class System699 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component478,Component314,Component235>()
.ForEach((Entity e) =>{
   var e1 = ecb.CreateEntity();
   ecb.AddComponent(e1, new TicksCooldownComponent(10));
  ecb.AddComponent(e1, new Component291());
 }).Run(); }
}

```

System with add or remmove component 

```
//leoecs
class System590 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component65,Component435,Component58> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component303>())
   {
    entity.Del<Component303>();
   }
   else
   {
    entity.Replace(new Component303());
   }
  }
 }
}


//leolite
class System590 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component65> _p1;
EcsPool<Component435> _p2;
EcsPool<Component58> _p3;
EcsPool<Component303> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component65>().Inc<Component435>().Inc<Component58>().End();
   _p1 = _world.GetPool<Component65>();
   _p2 = _world.GetPool<Component435>();
   _p3 = _world.GetPool<Component58>();
   _pl = _world.GetPool<Component303>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

//entitas
class System590 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System590(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent65,GameMatcher.EcsGeneratorEntitasComponent435,GameMatcher.EcsGeneratorEntitasComponent58));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var entity = entities[i];
   if (entity.isEcsGeneratorEntitasComponent303)
   {
    entity.isEcsGeneratorEntitasComponent303=false;
   }
   else
   {
    entity.isEcsGeneratorEntitasComponent303=true;
   }
  }
 }
}

// unity ecs EntityManage
[AlwaysUpdateSystem]
class System590 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
Entities.WithoutBurst().WithStructuralChanges()
.WithAll<Component65,Component435,Component58>()
.ForEach((Entity e) =>{
if (HasComponent<Component303>(e))
   {
    _em.RemoveComponent<Component303>(e);
   }
   else
   {
    _em.AddComponent<Component303>(e);
   }
 }).Run(); }
}

//unity ecs with CommandBuffer - not same output
[AlwaysUpdateSystem]
class System590 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component65,Component435,Component58>()
.ForEach((Entity e) =>{
if (HasComponent<Component303>(e))
   {
    ecb.RemoveComponent<Component303>(e);
   }
   else
   {
    ecb.AddComponent<Component303>(e);
   }
 }).Run(); }
}
```
