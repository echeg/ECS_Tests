using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System296 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component404> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component21>())
   {
    entity.Del<Component21>();
   }
   else
   {
    entity.Replace(new Component21());
   }
  }
 }
}

}
