using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System262 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component214,Component270,Component269> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component109>())
   {
    entity.Del<Component109>();
   }
   else
   {
    entity.Replace(new Component109());
   }
  }
 }
}

}
