using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System106 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component370> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component85>())
   {
    entity.Del<Component85>();
   }
   else
   {
    entity.Replace(new Component85());
   }
  }
 }
}

}
