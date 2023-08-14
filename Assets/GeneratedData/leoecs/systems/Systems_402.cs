using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System402 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component318,Component367,Component235,Component435> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component17>())
   {
    q+=1;
    var com = entity.Get<Component17>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
