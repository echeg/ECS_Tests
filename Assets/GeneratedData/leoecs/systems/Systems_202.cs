using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System202 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component103,Component42,Component110> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component494>())
   {
    entity.Del<Component494>();
   }
   else
   {
    entity.Replace(new Component494());
   }
  }
 }
}

}
