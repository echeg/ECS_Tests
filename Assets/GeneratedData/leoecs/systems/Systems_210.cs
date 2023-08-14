using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System210 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component105,Component384> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component323>())
   {
    entity.Del<Component323>();
   }
   else
   {
    entity.Replace(new Component323());
   }
  }
 }
}

}
