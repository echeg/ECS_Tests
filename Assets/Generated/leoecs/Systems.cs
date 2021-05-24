using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System0 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component12,Component32,Component27> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System1 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component16,Component6> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System2 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component22,Component1> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System3 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component16> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System4 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component11,Component47,Component27,Component16> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System5 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component40,Component22,Component20> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System6 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component44,Component3,Component35,Component0> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System7 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component13,Component49,Component14> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System8 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System9 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component42,Component15> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System10 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component30> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System11 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component43,Component16,Component41,Component26> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System12 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component42,Component41> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System13 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component5,Component1,Component11,Component37> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System14 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component45> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System15 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component10,Component21,Component37> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
  }
 }
}

class System16 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46,Component16> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System17 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component43,Component22,Component7,Component0> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
  }
 }
}

class System18 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component44> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System19 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System20 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component47,Component25,Component37,Component23> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System21 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component44,Component17,Component1> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System22 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46,Component44> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System23 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component1,Component12,Component44> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System24 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component7,Component38,Component31> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System25 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component15,Component6,Component43,Component27> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System26 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component48,Component3,Component16> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System27 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component34,Component44,Component2,Component5> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System28 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component40,Component44> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System29 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component22,Component2,Component16> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System30 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component36> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System31 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component49> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
  }
 }
}

class System32 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component14,Component41> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System33 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component13> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System34 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component48,Component5> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System35 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component2,Component28> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System36 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component31,Component10,Component46,Component32> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System37 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component1,Component9,Component27,Component2> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System38 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component19,Component34,Component21,Component0> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System39 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component35,Component15,Component41> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
  }
 }
}

class System40 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component45,Component44,Component6> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System41 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component6> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System42 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3,Component18,Component36,Component38> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System43 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3,Component39,Component0> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System44 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component26,Component25> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System45 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component1> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System46 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component33,Component47,Component29> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   var component2 = _filter.Get2 (i);
  }
 }
}

class System47 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component7,Component38,Component12,Component34> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System48 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component20,Component5> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   var component2 = _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

class System49 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component48> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

class System50 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component37,Component3,Component34,Component26> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component48>())
   {
    entity.Del<Component48>();
   }
   else
   {
    entity.Replace(new Component48());
   }
  }
 }
}

class System51 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component41,Component14,Component10> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component16>())
   {
    entity.Del<Component16>();
   }
   else
   {
    entity.Replace(new Component16());
   }
  }
 }
}

class System52 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component21,Component37,Component12,Component10> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component15>())
   {
    entity.Del<Component15>();
   }
   else
   {
    entity.Replace(new Component15());
   }
  }
 }
}

class System53 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component39,Component2,Component11,Component46> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component27>())
   {
    entity.Del<Component27>();
   }
   else
   {
    entity.Replace(new Component27());
   }
  }
 }
}

class System54 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component49,Component4> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component40>())
   {
    entity.Del<Component40>();
   }
   else
   {
    entity.Replace(new Component40());
   }
  }
 }
}

class System55 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component17,Component26> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component42>())
   {
    entity.Del<Component42>();
   }
   else
   {
    entity.Replace(new Component42());
   }
  }
 }
}

class System56 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component5,Component24,Component22,Component40> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component43>())
   {
    entity.Del<Component43>();
   }
   else
   {
    entity.Replace(new Component43());
   }
  }
 }
}

class System57 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component2,Component35,Component42> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component33>())
   {
    entity.Del<Component33>();
   }
   else
   {
    entity.Replace(new Component33());
   }
  }
 }
}

class System58 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component28,Component12> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component17>())
   {
    entity.Del<Component17>();
   }
   else
   {
    entity.Replace(new Component17());
   }
  }
 }
}

class System59 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component21,Component2> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component5>())
   {
    entity.Del<Component5>();
   }
   else
   {
    entity.Replace(new Component5());
   }
  }
 }
}

class System60 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component21,Component46> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component33>())
   {
    entity.Del<Component33>();
   }
   else
   {
    entity.Replace(new Component33());
   }
  }
 }
}

class System61 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component26,Component17,Component44> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component8>())
   {
    entity.Del<Component8>();
   }
   else
   {
    entity.Replace(new Component8());
   }
  }
 }
}

class System62 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component17> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component46>())
   {
    entity.Del<Component46>();
   }
   else
   {
    entity.Replace(new Component46());
   }
  }
 }
}

class System63 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component4,Component15> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component12>())
   {
    entity.Del<Component12>();
   }
   else
   {
    entity.Replace(new Component12());
   }
  }
 }
}

class System64 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component19,Component21,Component14,Component37> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component16>())
   {
    entity.Del<Component16>();
   }
   else
   {
    entity.Replace(new Component16());
   }
  }
 }
}

class System65 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component13,Component9> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component39>())
   {
    entity.Del<Component39>();
   }
   else
   {
    entity.Replace(new Component39());
   }
  }
 }
}

class System66 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component36,Component15,Component11> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component21>())
   {
    entity.Del<Component21>();
   }
   else
   {
    entity.Replace(new Component21());
   }
  }
 }
}

class System67 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component11> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component21>())
   {
    entity.Del<Component21>();
   }
   else
   {
    entity.Replace(new Component21());
   }
  }
 }
}

class System68 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component22,Component33,Component46,Component23> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component16>())
   {
    entity.Del<Component16>();
   }
   else
   {
    entity.Replace(new Component16());
   }
  }
 }
}

class System69 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component44,Component28,Component25> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component36>())
   {
    entity.Del<Component36>();
   }
   else
   {
    entity.Replace(new Component36());
   }
  }
 }
}

class System70 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3,Component7,Component1> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component11>())
   {
    entity.Del<Component11>();
   }
   else
   {
    entity.Replace(new Component11());
   }
  }
 }
}

class System71 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component33,Component34,Component49> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component33>())
   {
    entity.Del<Component33>();
   }
   else
   {
    entity.Replace(new Component33());
   }
  }
 }
}

class System72 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component14,Component27,Component17> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component27>())
   {
    entity.Del<Component27>();
   }
   else
   {
    entity.Replace(new Component27());
   }
  }
 }
}

class System73 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component7,Component42,Component45> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component34>())
   {
    entity.Del<Component34>();
   }
   else
   {
    entity.Replace(new Component34());
   }
  }
 }
}

class System74 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3,Component10> _filter = null;
 public void Run () {
  for (var i = 0; i<_filter.GetEntitiesCount(); i++) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component43>())
   {
    entity.Del<Component43>();
   }
   else
   {
    entity.Replace(new Component43());
   }
  }
 }
}

}
