using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System147 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component102,Component231,Component490> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component337>())
   {
    entity.Del<Component337>();
   }
   else
   {
    entity.Replace(new Component337());
   }
  }
 }
}

}
