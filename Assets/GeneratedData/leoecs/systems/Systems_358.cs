using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System358 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component246> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component384>())
   {
    entity.Del<Component384>();
   }
   else
   {
    entity.Replace(new Component384());
   }
  }
 }
}

}
