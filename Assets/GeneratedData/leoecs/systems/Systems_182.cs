using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System182 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component408,Component12,Component157> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component224>())
   {
    entity.Del<Component224>();
   }
   else
   {
    entity.Replace(new Component224());
   }
  }
 }
}

}
