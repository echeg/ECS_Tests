using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System14 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component416,Component204,Component90> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component203>())
   {
    q+=1;
    var com = entity.Get<Component203>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component444>())
   {
    q+=1;
    var com = entity.Get<Component444>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component5>())
   {
    q+=1;
    var com = entity.Get<Component5>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component166>())
   {
    q+=1;
    var com = entity.Get<Component166>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
