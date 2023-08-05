using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System124 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component126,Component495,Component464,Component50> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component116>())
   {
    entity.Del<Component116>();
   }
   else
   {
    entity.Replace(new Component116());
   }
  }
 }
}

}
