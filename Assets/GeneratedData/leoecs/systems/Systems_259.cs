using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System259 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component68> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component120>())
   {
    entity.Del<Component120>();
   }
   else
   {
    entity.Replace(new Component120());
   }
  }
 }
}

}