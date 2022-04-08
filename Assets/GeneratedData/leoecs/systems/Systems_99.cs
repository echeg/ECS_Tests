using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System99 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component446> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component220>())
   {
    q+=1;
    var com = entity.Get<Component220>();
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
   if (entity.Has<Component137>())
   {
    q+=1;
    var com = entity.Get<Component137>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component361>())
   {
    q+=1;
    var com = entity.Get<Component361>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
