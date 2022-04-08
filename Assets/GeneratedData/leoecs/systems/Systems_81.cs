using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System81 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component346> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component166>())
   {
    q+=1;
    var com = entity.Get<Component166>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component364>())
   {
    q+=1;
    var com = entity.Get<Component364>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component208>())
   {
    q+=1;
    var com = entity.Get<Component208>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component480>())
   {
    q+=1;
    var com = entity.Get<Component480>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
