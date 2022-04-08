using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System60 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component478,Component490,Component345> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component488>())
   {
    q+=1;
    var com = entity.Get<Component488>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component271>())
   {
    q+=1;
    var com = entity.Get<Component271>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component83>())
   {
    q+=1;
    var com = entity.Get<Component83>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component478>())
   {
    q+=1;
    var com = entity.Get<Component478>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
