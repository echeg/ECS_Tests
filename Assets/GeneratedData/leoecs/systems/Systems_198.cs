using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System198 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component39,Component490> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component219>())
   {
    entity.Del<Component219>();
   }
   else
   {
    entity.Replace(new Component219());
   }
  }
 }
}

}
