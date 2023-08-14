using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System311 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component406,Component123> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component147>())
   {
    entity.Del<Component147>();
   }
   else
   {
    entity.Replace(new Component147());
   }
  }
 }
}

}
