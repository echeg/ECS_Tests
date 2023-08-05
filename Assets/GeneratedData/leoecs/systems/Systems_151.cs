using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System151 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component435,Component367,Component282,Component357> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component109>())
   {
    entity.Del<Component109>();
   }
   else
   {
    entity.Replace(new Component109());
   }
  }
 }
}

}
