using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System387 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component68,Component368,Component50> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component204>())
   {
    entity.Del<Component204>();
   }
   else
   {
    entity.Replace(new Component204());
   }
  }
 }
}

}
