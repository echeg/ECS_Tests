using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System239 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component192> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component8>())
   {
    entity.Del<Component8>();
   }
   else
   {
    entity.Replace(new Component8());
   }
  }
 }
}

}
