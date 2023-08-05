using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System208 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component160,Component344,Component178,Component275> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component282>())
   {
    q+=1;
    var com = entity.Get<Component282>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component152>())
   {
    q+=1;
    var com = entity.Get<Component152>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component26>())
   {
    q+=1;
    var com = entity.Get<Component26>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component324>())
   {
    q+=1;
    var com = entity.Get<Component324>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
