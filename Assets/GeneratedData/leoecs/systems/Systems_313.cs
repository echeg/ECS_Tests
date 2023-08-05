using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System313 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component26>())
   {
    q+=1;
    var com = entity.Get<Component26>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component43>())
   {
    q+=1;
    var com = entity.Get<Component43>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component363>())
   {
    q+=1;
    var com = entity.Get<Component363>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component139>())
   {
    q+=1;
    var com = entity.Get<Component139>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
