using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System469 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component109,Component315,Component471> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component88>())
   {
    q+=1;
    var com = entity.Get<Component88>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
