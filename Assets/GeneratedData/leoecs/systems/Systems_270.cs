using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System270 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component105,Component47,Component357> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component21>())
   {
    entity.Del<Component21>();
   }
   else
   {
    entity.Replace(new Component21());
   }
  }
 }
}

}
