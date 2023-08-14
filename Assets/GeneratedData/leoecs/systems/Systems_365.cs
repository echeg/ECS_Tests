using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System365 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component324,Component187> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component270>())
   {
    entity.Del<Component270>();
   }
   else
   {
    entity.Replace(new Component270());
   }
  }
 }
}

}
