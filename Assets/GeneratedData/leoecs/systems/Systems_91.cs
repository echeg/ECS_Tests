using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System91 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component361,Component192,Component133> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component248>())
   {
    q+=1;
    var com = entity.Get<Component248>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component235>())
   {
    q+=1;
    var com = entity.Get<Component235>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component494>())
   {
    q+=1;
    var com = entity.Get<Component494>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component266>())
   {
    q+=1;
    var com = entity.Get<Component266>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
