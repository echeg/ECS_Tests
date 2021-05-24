using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System0 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component12> _p1;
EcsPool<Component32> _p2;
EcsPool<Component27> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component12>().Inc<Component32>().Inc<Component27>().End();
   _p1 = _world.GetPool<Component12>();
   _p2 = _world.GetPool<Component32>();
   _p3 = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component16> _p1;
EcsPool<Component6> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component16>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component16>();
   _p2 = _world.GetPool<Component6>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System2 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component1> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component1>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component1>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System3 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component16> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component16>().End();
   _p1 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System4 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component11> _p1;
EcsPool<Component47> _p2;
EcsPool<Component27> _p3;
EcsPool<Component16> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component11>().Inc<Component47>().Inc<Component27>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component11>();
   _p2 = _world.GetPool<Component47>();
   _p3 = _world.GetPool<Component27>();
   _p4 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component40> _p1;
EcsPool<Component22> _p2;
EcsPool<Component20> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component40>().Inc<Component22>().Inc<Component20>().End();
   _p1 = _world.GetPool<Component40>();
   _p2 = _world.GetPool<Component22>();
   _p3 = _world.GetPool<Component20>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
EcsPool<Component3> _p2;
EcsPool<Component35> _p3;
EcsPool<Component0> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().Inc<Component3>().Inc<Component35>().Inc<Component0>().End();
   _p1 = _world.GetPool<Component44>();
   _p2 = _world.GetPool<Component3>();
   _p3 = _world.GetPool<Component35>();
   _p4 = _world.GetPool<Component0>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System7 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component49> _p2;
EcsPool<Component14> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component49>().Inc<Component14>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component49>();
   _p3 = _world.GetPool<Component14>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().End();
   _p1 = _world.GetPool<Component3>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System9 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component42> _p1;
EcsPool<Component15> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component42>().Inc<Component15>().End();
   _p1 = _world.GetPool<Component42>();
   _p2 = _world.GetPool<Component15>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System10 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component30> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component30>().End();
   _p1 = _world.GetPool<Component30>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component43> _p1;
EcsPool<Component16> _p2;
EcsPool<Component41> _p3;
EcsPool<Component26> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component43>().Inc<Component16>().Inc<Component41>().Inc<Component26>().End();
   _p1 = _world.GetPool<Component43>();
   _p2 = _world.GetPool<Component16>();
   _p3 = _world.GetPool<Component41>();
   _p4 = _world.GetPool<Component26>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System12 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component42> _p1;
EcsPool<Component41> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component42>().Inc<Component41>().End();
   _p1 = _world.GetPool<Component42>();
   _p2 = _world.GetPool<Component41>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System13 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component5> _p1;
EcsPool<Component1> _p2;
EcsPool<Component11> _p3;
EcsPool<Component37> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component5>().Inc<Component1>().Inc<Component11>().Inc<Component37>().End();
   _p1 = _world.GetPool<Component5>();
   _p2 = _world.GetPool<Component1>();
   _p3 = _world.GetPool<Component11>();
   _p4 = _world.GetPool<Component37>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System14 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component45> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component45>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component45>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component10> _p1;
EcsPool<Component21> _p2;
EcsPool<Component37> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component10>().Inc<Component21>().Inc<Component37>().End();
   _p1 = _world.GetPool<Component10>();
   _p2 = _world.GetPool<Component21>();
   _p3 = _world.GetPool<Component37>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
  }
 }
}

class System16 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component46> _p1;
EcsPool<Component16> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component46>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component46>();
   _p2 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System17 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component43> _p1;
EcsPool<Component22> _p2;
EcsPool<Component7> _p3;
EcsPool<Component0> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component43>().Inc<Component22>().Inc<Component7>().Inc<Component0>().End();
   _p1 = _world.GetPool<Component43>();
   _p2 = _world.GetPool<Component22>();
   _p3 = _world.GetPool<Component7>();
   _p4 = _world.GetPool<Component0>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
  }
 }
}

class System18 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().End();
   _p1 = _world.GetPool<Component44>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component46> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component46>().End();
   _p1 = _world.GetPool<Component46>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System20 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
EcsPool<Component25> _p2;
EcsPool<Component37> _p3;
EcsPool<Component23> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().Inc<Component25>().Inc<Component37>().Inc<Component23>().End();
   _p1 = _world.GetPool<Component47>();
   _p2 = _world.GetPool<Component25>();
   _p3 = _world.GetPool<Component37>();
   _p4 = _world.GetPool<Component23>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System21 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
EcsPool<Component17> _p2;
EcsPool<Component1> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().Inc<Component17>().Inc<Component1>().End();
   _p1 = _world.GetPool<Component44>();
   _p2 = _world.GetPool<Component17>();
   _p3 = _world.GetPool<Component1>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System22 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component46> _p1;
EcsPool<Component44> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component46>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component46>();
   _p2 = _world.GetPool<Component44>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System23 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component1> _p1;
EcsPool<Component12> _p2;
EcsPool<Component44> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component1>().Inc<Component12>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component1>();
   _p2 = _world.GetPool<Component12>();
   _p3 = _world.GetPool<Component44>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component7> _p1;
EcsPool<Component38> _p2;
EcsPool<Component31> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component7>().Inc<Component38>().Inc<Component31>().End();
   _p1 = _world.GetPool<Component7>();
   _p2 = _world.GetPool<Component38>();
   _p3 = _world.GetPool<Component31>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System25 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component15> _p1;
EcsPool<Component6> _p2;
EcsPool<Component43> _p3;
EcsPool<Component27> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component15>().Inc<Component6>().Inc<Component43>().Inc<Component27>().End();
   _p1 = _world.GetPool<Component15>();
   _p2 = _world.GetPool<Component6>();
   _p3 = _world.GetPool<Component43>();
   _p4 = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System26 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component48> _p1;
EcsPool<Component3> _p2;
EcsPool<Component16> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component48>().Inc<Component3>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component48>();
   _p2 = _world.GetPool<Component3>();
   _p3 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System27 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component34> _p1;
EcsPool<Component44> _p2;
EcsPool<Component2> _p3;
EcsPool<Component5> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component34>().Inc<Component44>().Inc<Component2>().Inc<Component5>().End();
   _p1 = _world.GetPool<Component34>();
   _p2 = _world.GetPool<Component44>();
   _p3 = _world.GetPool<Component2>();
   _p4 = _world.GetPool<Component5>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System28 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component40> _p1;
EcsPool<Component44> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component40>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component40>();
   _p2 = _world.GetPool<Component44>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System29 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component2> _p2;
EcsPool<Component16> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component2>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component2>();
   _p3 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System30 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().End();
   _p1 = _world.GetPool<Component36>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System31 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component49> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component49>().End();
   _p1 = _world.GetPool<Component49>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
  }
 }
}

class System32 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component14> _p1;
EcsPool<Component41> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component14>().Inc<Component41>().End();
   _p1 = _world.GetPool<Component14>();
   _p2 = _world.GetPool<Component41>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().End();
   _p1 = _world.GetPool<Component13>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component48> _p1;
EcsPool<Component5> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component48>().Inc<Component5>().End();
   _p1 = _world.GetPool<Component48>();
   _p2 = _world.GetPool<Component5>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System35 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component2> _p1;
EcsPool<Component28> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().Inc<Component28>().End();
   _p1 = _world.GetPool<Component2>();
   _p2 = _world.GetPool<Component28>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System36 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component10> _p2;
EcsPool<Component46> _p3;
EcsPool<Component32> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().Inc<Component10>().Inc<Component46>().Inc<Component32>().End();
   _p1 = _world.GetPool<Component31>();
   _p2 = _world.GetPool<Component10>();
   _p3 = _world.GetPool<Component46>();
   _p4 = _world.GetPool<Component32>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component1> _p1;
EcsPool<Component9> _p2;
EcsPool<Component27> _p3;
EcsPool<Component2> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component1>().Inc<Component9>().Inc<Component27>().Inc<Component2>().End();
   _p1 = _world.GetPool<Component1>();
   _p2 = _world.GetPool<Component9>();
   _p3 = _world.GetPool<Component27>();
   _p4 = _world.GetPool<Component2>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System38 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component19> _p1;
EcsPool<Component34> _p2;
EcsPool<Component21> _p3;
EcsPool<Component0> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component19>().Inc<Component34>().Inc<Component21>().Inc<Component0>().End();
   _p1 = _world.GetPool<Component19>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component21>();
   _p4 = _world.GetPool<Component0>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System39 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component35> _p1;
EcsPool<Component15> _p2;
EcsPool<Component41> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component35>().Inc<Component15>().Inc<Component41>().End();
   _p1 = _world.GetPool<Component35>();
   _p2 = _world.GetPool<Component15>();
   _p3 = _world.GetPool<Component41>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
  }
 }
}

class System40 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component45> _p1;
EcsPool<Component44> _p2;
EcsPool<Component6> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component45>().Inc<Component44>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component45>();
   _p2 = _world.GetPool<Component44>();
   _p3 = _world.GetPool<Component6>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System41 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component6> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component6>().End();
   _p1 = _world.GetPool<Component6>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System42 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
EcsPool<Component18> _p2;
EcsPool<Component36> _p3;
EcsPool<Component38> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().Inc<Component18>().Inc<Component36>().Inc<Component38>().End();
   _p1 = _world.GetPool<Component3>();
   _p2 = _world.GetPool<Component18>();
   _p3 = _world.GetPool<Component36>();
   _p4 = _world.GetPool<Component38>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System43 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
EcsPool<Component39> _p2;
EcsPool<Component0> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().Inc<Component39>().Inc<Component0>().End();
   _p1 = _world.GetPool<Component3>();
   _p2 = _world.GetPool<Component39>();
   _p3 = _world.GetPool<Component0>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System44 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component26> _p1;
EcsPool<Component25> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component26>().Inc<Component25>().End();
   _p1 = _world.GetPool<Component26>();
   _p2 = _world.GetPool<Component25>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System45 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component1> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component1>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component1>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System46 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component33> _p1;
EcsPool<Component47> _p2;
EcsPool<Component29> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component33>().Inc<Component47>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component33>();
   _p2 = _world.GetPool<Component47>();
   _p3 = _world.GetPool<Component29>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var component2 = _p2.Get (entities[i]);
  }
 }
}

class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component7> _p1;
EcsPool<Component38> _p2;
EcsPool<Component12> _p3;
EcsPool<Component34> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component7>().Inc<Component38>().Inc<Component12>().Inc<Component34>().End();
   _p1 = _world.GetPool<Component7>();
   _p2 = _world.GetPool<Component38>();
   _p3 = _world.GetPool<Component12>();
   _p4 = _world.GetPool<Component34>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component20> _p1;
EcsPool<Component5> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component20>().Inc<Component5>().End();
   _p1 = _world.GetPool<Component20>();
   _p2 = _world.GetPool<Component5>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   var component2 = _p2.Get (entities[i]);
   component1.Field0 += component2.Field0;
  }
 }
}

class System49 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component48> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component48>().End();
   _p1 = _world.GetPool<Component48>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   ref var component1 = ref _p1.Get (entities[i]);
   component1.Field0 += 1;
  }
 }
}

class System50 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component37> _p1;
EcsPool<Component3> _p2;
EcsPool<Component34> _p3;
EcsPool<Component26> _p4;
EcsPool<Component48> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component37>().Inc<Component3>().Inc<Component34>().Inc<Component26>().End();
   _p1 = _world.GetPool<Component37>();
   _p2 = _world.GetPool<Component3>();
   _p3 = _world.GetPool<Component34>();
   _p4 = _world.GetPool<Component26>();
   _pl = _world.GetPool<Component48>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System51 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component41> _p1;
EcsPool<Component14> _p2;
EcsPool<Component10> _p3;
EcsPool<Component16> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component41>().Inc<Component14>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component41>();
   _p2 = _world.GetPool<Component14>();
   _p3 = _world.GetPool<Component10>();
   _pl = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System52 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component21> _p1;
EcsPool<Component37> _p2;
EcsPool<Component12> _p3;
EcsPool<Component10> _p4;
EcsPool<Component15> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component21>().Inc<Component37>().Inc<Component12>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component21>();
   _p2 = _world.GetPool<Component37>();
   _p3 = _world.GetPool<Component12>();
   _p4 = _world.GetPool<Component10>();
   _pl = _world.GetPool<Component15>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System53 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component39> _p1;
EcsPool<Component2> _p2;
EcsPool<Component11> _p3;
EcsPool<Component46> _p4;
EcsPool<Component27> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component39>().Inc<Component2>().Inc<Component11>().Inc<Component46>().End();
   _p1 = _world.GetPool<Component39>();
   _p2 = _world.GetPool<Component2>();
   _p3 = _world.GetPool<Component11>();
   _p4 = _world.GetPool<Component46>();
   _pl = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System54 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component49> _p1;
EcsPool<Component4> _p2;
EcsPool<Component40> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component49>().Inc<Component4>().End();
   _p1 = _world.GetPool<Component49>();
   _p2 = _world.GetPool<Component4>();
   _pl = _world.GetPool<Component40>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component17> _p2;
EcsPool<Component26> _p3;
EcsPool<Component42> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component17>().Inc<Component26>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component17>();
   _p3 = _world.GetPool<Component26>();
   _pl = _world.GetPool<Component42>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System56 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component5> _p1;
EcsPool<Component24> _p2;
EcsPool<Component22> _p3;
EcsPool<Component40> _p4;
EcsPool<Component43> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component5>().Inc<Component24>().Inc<Component22>().Inc<Component40>().End();
   _p1 = _world.GetPool<Component5>();
   _p2 = _world.GetPool<Component24>();
   _p3 = _world.GetPool<Component22>();
   _p4 = _world.GetPool<Component40>();
   _pl = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component2> _p1;
EcsPool<Component35> _p2;
EcsPool<Component42> _p3;
EcsPool<Component33> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().Inc<Component35>().Inc<Component42>().End();
   _p1 = _world.GetPool<Component2>();
   _p2 = _world.GetPool<Component35>();
   _p3 = _world.GetPool<Component42>();
   _pl = _world.GetPool<Component33>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component28> _p1;
EcsPool<Component12> _p2;
EcsPool<Component17> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component28>().Inc<Component12>().End();
   _p1 = _world.GetPool<Component28>();
   _p2 = _world.GetPool<Component12>();
   _pl = _world.GetPool<Component17>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component21> _p1;
EcsPool<Component2> _p2;
EcsPool<Component5> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component21>().Inc<Component2>().End();
   _p1 = _world.GetPool<Component21>();
   _p2 = _world.GetPool<Component2>();
   _pl = _world.GetPool<Component5>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System60 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component21> _p1;
EcsPool<Component46> _p2;
EcsPool<Component33> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component21>().Inc<Component46>().End();
   _p1 = _world.GetPool<Component21>();
   _p2 = _world.GetPool<Component46>();
   _pl = _world.GetPool<Component33>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System61 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component26> _p1;
EcsPool<Component17> _p2;
EcsPool<Component44> _p3;
EcsPool<Component8> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component26>().Inc<Component17>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component26>();
   _p2 = _world.GetPool<Component17>();
   _p3 = _world.GetPool<Component44>();
   _pl = _world.GetPool<Component8>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System62 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component17> _p1;
EcsPool<Component46> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component17>().End();
   _p1 = _world.GetPool<Component17>();
   _pl = _world.GetPool<Component46>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System63 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component4> _p2;
EcsPool<Component15> _p3;
EcsPool<Component12> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component4>().Inc<Component15>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component4>();
   _p3 = _world.GetPool<Component15>();
   _pl = _world.GetPool<Component12>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System64 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component19> _p1;
EcsPool<Component21> _p2;
EcsPool<Component14> _p3;
EcsPool<Component37> _p4;
EcsPool<Component16> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component19>().Inc<Component21>().Inc<Component14>().Inc<Component37>().End();
   _p1 = _world.GetPool<Component19>();
   _p2 = _world.GetPool<Component21>();
   _p3 = _world.GetPool<Component14>();
   _p4 = _world.GetPool<Component37>();
   _pl = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System65 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component9> _p2;
EcsPool<Component39> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component9>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component9>();
   _pl = _world.GetPool<Component39>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System66 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
EcsPool<Component15> _p2;
EcsPool<Component11> _p3;
EcsPool<Component21> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().Inc<Component15>().Inc<Component11>().End();
   _p1 = _world.GetPool<Component36>();
   _p2 = _world.GetPool<Component15>();
   _p3 = _world.GetPool<Component11>();
   _pl = _world.GetPool<Component21>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System67 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component11> _p1;
EcsPool<Component21> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component11>().End();
   _p1 = _world.GetPool<Component11>();
   _pl = _world.GetPool<Component21>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System68 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component33> _p2;
EcsPool<Component46> _p3;
EcsPool<Component23> _p4;
EcsPool<Component16> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component33>().Inc<Component46>().Inc<Component23>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component33>();
   _p3 = _world.GetPool<Component46>();
   _p4 = _world.GetPool<Component23>();
   _pl = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
EcsPool<Component28> _p2;
EcsPool<Component25> _p3;
EcsPool<Component36> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().Inc<Component28>().Inc<Component25>().End();
   _p1 = _world.GetPool<Component44>();
   _p2 = _world.GetPool<Component28>();
   _p3 = _world.GetPool<Component25>();
   _pl = _world.GetPool<Component36>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System70 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
EcsPool<Component7> _p2;
EcsPool<Component1> _p3;
EcsPool<Component11> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().Inc<Component7>().Inc<Component1>().End();
   _p1 = _world.GetPool<Component3>();
   _p2 = _world.GetPool<Component7>();
   _p3 = _world.GetPool<Component1>();
   _pl = _world.GetPool<Component11>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System71 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component33> _p1;
EcsPool<Component34> _p2;
EcsPool<Component49> _p3;
EcsPool<Component33> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component33>().Inc<Component34>().Inc<Component49>().End();
   _p1 = _world.GetPool<Component33>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component49>();
   _pl = _world.GetPool<Component33>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System72 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component14> _p1;
EcsPool<Component27> _p2;
EcsPool<Component17> _p3;
EcsPool<Component27> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component14>().Inc<Component27>().Inc<Component17>().End();
   _p1 = _world.GetPool<Component14>();
   _p2 = _world.GetPool<Component27>();
   _p3 = _world.GetPool<Component17>();
   _pl = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System73 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component7> _p1;
EcsPool<Component42> _p2;
EcsPool<Component45> _p3;
EcsPool<Component34> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component7>().Inc<Component42>().Inc<Component45>().End();
   _p1 = _world.GetPool<Component7>();
   _p2 = _world.GetPool<Component42>();
   _p3 = _world.GetPool<Component45>();
   _pl = _world.GetPool<Component34>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

class System74 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
EcsPool<Component10> _p2;
EcsPool<Component43> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component3>();
   _p2 = _world.GetPool<Component10>();
   _pl = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  var entities = _filter.GetRawEntities();
  for (int i = 0, iMax = _filter.GetEntitiesCount(); i < iMax; i++){
   var entity = entities[i];
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

}
