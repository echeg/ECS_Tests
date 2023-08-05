using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System209 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component91,Component150,Component143,Component301> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component430>())
   {
    q+=1;
    var com = entity.Get<Component430>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component195>())
   {
    q+=1;
    var com = entity.Get<Component195>();
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
