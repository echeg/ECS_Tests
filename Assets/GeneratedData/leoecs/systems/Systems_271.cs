using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System271 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component385,Component408,Component435,Component7> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component457>())
   {
    entity.Del<Component457>();
   }
   else
   {
    entity.Replace(new Component457());
   }
  }
 }
}

}
