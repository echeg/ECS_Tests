using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System43 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component352,Component298,Component353,Component67> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component266>())
   {
    q+=1;
    var com = entity.Get<Component266>();
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
   if (entity.Has<Component220>())
   {
    q+=1;
    var com = entity.Get<Component220>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component137>())
   {
    q+=1;
    var com = entity.Get<Component137>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
