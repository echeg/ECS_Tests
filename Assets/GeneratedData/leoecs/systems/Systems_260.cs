using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System260 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component170> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component5>())
   {
    q+=1;
    var com = entity.Get<Component5>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component224>())
   {
    q+=1;
    var com = entity.Get<Component224>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component488>())
   {
    q+=1;
    var com = entity.Get<Component488>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component396>())
   {
    q+=1;
    var com = entity.Get<Component396>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
