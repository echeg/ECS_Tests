using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System317 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component403,Component409,Component163,Component17> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component316>())
   {
    entity.Del<Component316>();
   }
   else
   {
    entity.Replace(new Component316());
   }
  }
 }
}

}
