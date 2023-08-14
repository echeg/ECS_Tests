using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System334 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component212,Component378> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component78>())
   {
    entity.Del<Component78>();
   }
   else
   {
    entity.Replace(new Component78());
   }
  }
 }
}

}
