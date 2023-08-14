using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System283 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component136,Component460,Component422> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component202>())
   {
    entity.Del<Component202>();
   }
   else
   {
    entity.Replace(new Component202());
   }
  }
 }
}

}
