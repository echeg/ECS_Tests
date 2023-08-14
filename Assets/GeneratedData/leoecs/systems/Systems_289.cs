using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System289 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component292> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component283>())
   {
    entity.Del<Component283>();
   }
   else
   {
    entity.Replace(new Component283());
   }
  }
 }
}

}
