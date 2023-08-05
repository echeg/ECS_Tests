using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System155 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component139,Component396,Component379,Component426> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component261>())
   {
    entity.Del<Component261>();
   }
   else
   {
    entity.Replace(new Component261());
   }
  }
 }
}

}
