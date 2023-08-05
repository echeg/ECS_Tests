using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System196 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component444> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component271>())
   {
    entity.Del<Component271>();
   }
   else
   {
    entity.Replace(new Component271());
   }
  }
 }
}

}
