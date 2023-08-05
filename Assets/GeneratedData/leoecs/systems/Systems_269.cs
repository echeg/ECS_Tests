using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System269 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component13,Component170,Component485,Component40> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component94>())
   {
    q+=1;
    var com = entity.Get<Component94>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component314>())
   {
    q+=1;
    var com = entity.Get<Component314>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component283>())
   {
    q+=1;
    var com = entity.Get<Component283>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component333>())
   {
    q+=1;
    var com = entity.Get<Component333>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
