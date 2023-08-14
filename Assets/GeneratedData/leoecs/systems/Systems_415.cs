using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System415 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component345,Component10,Component13,Component90> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
