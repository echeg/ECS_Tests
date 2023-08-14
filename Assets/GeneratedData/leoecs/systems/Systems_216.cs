using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System216 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component189,Component195,Component495> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component389>())
   {
    entity.Del<Component389>();
   }
   else
   {
    entity.Replace(new Component389());
   }
  }
 }
}

}
