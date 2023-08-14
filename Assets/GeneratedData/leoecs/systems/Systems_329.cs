using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System329 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component185> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component198>())
   {
    entity.Del<Component198>();
   }
   else
   {
    entity.Replace(new Component198());
   }
  }
 }
}

}