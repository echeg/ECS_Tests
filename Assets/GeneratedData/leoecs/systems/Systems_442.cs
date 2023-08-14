using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System442 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component367> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component235>())
   {
    q+=1;
    var com = entity.Get<Component235>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
