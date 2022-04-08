using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System16 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component445,Component498> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component47>())
   {
    q+=1;
    var com = entity.Get<Component47>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component127>())
   {
    q+=1;
    var com = entity.Get<Component127>();
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
   if (entity.Has<Component122>())
   {
    q+=1;
    var com = entity.Get<Component122>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
