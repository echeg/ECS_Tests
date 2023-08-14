using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System480 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component358,Component12> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component128>())
   {
    q+=1;
    var com = entity.Get<Component128>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
