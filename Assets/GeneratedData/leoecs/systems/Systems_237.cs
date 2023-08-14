using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System237 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component462,Component262> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component84>())
   {
    entity.Del<Component84>();
   }
   else
   {
    entity.Replace(new Component84());
   }
  }
 }
}

}
