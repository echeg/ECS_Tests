using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System380 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component490,Component229,Component307> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component64>())
   {
    entity.Del<Component64>();
   }
   else
   {
    entity.Replace(new Component64());
   }
  }
 }
}

}
