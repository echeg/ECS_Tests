using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System375 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component439> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component359>())
   {
    entity.Del<Component359>();
   }
   else
   {
    entity.Replace(new Component359());
   }
  }
 }
}

}
