using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System323 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component488> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component38>())
   {
    entity.Del<Component38>();
   }
   else
   {
    entity.Replace(new Component38());
   }
  }
 }
}

}
