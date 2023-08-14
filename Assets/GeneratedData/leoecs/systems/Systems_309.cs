using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System309 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component445,Component146> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component139>())
   {
    entity.Del<Component139>();
   }
   else
   {
    entity.Replace(new Component139());
   }
  }
 }
}

}
