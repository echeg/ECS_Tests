using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System400 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component466> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component367>())
   {
    q+=1;
    var com = entity.Get<Component367>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
