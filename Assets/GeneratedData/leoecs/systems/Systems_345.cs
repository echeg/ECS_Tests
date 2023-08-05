using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System345 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component28,Component290,Component223,Component35> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component2>())
   {
    q+=1;
    var com = entity.Get<Component2>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component92>())
   {
    q+=1;
    var com = entity.Get<Component92>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component30>())
   {
    q+=1;
    var com = entity.Get<Component30>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component371>())
   {
    q+=1;
    var com = entity.Get<Component371>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
