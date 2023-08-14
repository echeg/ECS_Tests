using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System368 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component421,Component424> _filter = null;
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
