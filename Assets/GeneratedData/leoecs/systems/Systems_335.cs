using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System335 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component143,Component185,Component386> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component204>())
   {
    q+=1;
    var com = entity.Get<Component204>();
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
   if (entity.Has<Component389>())
   {
    q+=1;
    var com = entity.Get<Component389>();
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
  }
 }
}

}
