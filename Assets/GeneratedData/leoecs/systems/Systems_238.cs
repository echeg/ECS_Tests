using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System238 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component180,Component221> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component1>())
   {
    entity.Del<Component1>();
   }
   else
   {
    entity.Replace(new Component1());
   }
  }
 }
}

}
