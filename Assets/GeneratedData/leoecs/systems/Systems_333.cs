using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System333 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component499> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component49>())
   {
    q+=1;
    var com = entity.Get<Component49>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component21>())
   {
    q+=1;
    var com = entity.Get<Component21>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component270>())
   {
    q+=1;
    var com = entity.Get<Component270>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component58>())
   {
    q+=1;
    var com = entity.Get<Component58>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
