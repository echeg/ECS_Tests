using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System76 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component40,Component209,Component271> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component335>())
   {
    q+=1;
    var com = entity.Get<Component335>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component447>())
   {
    q+=1;
    var com = entity.Get<Component447>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component435>())
   {
    q+=1;
    var com = entity.Get<Component435>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component367>())
   {
    q+=1;
    var com = entity.Get<Component367>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
