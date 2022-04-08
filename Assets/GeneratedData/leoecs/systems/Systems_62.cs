using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System62 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component65> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component105>())
   {
    q+=1;
    var com = entity.Get<Component105>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component149>())
   {
    q+=1;
    var com = entity.Get<Component149>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component486>())
   {
    q+=1;
    var com = entity.Get<Component486>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component368>())
   {
    q+=1;
    var com = entity.Get<Component368>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
