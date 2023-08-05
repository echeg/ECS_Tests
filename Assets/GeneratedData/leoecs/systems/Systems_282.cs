using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System282 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component293> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component9>())
   {
    q+=1;
    var com = entity.Get<Component9>();
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
   if (entity.Has<Component85>())
   {
    q+=1;
    var com = entity.Get<Component85>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component301>())
   {
    q+=1;
    var com = entity.Get<Component301>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
