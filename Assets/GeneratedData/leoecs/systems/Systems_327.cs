using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System327 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component496> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component40>())
   {
    entity.Del<Component40>();
   }
   else
   {
    entity.Replace(new Component40());
   }
  }
 }
}

}
