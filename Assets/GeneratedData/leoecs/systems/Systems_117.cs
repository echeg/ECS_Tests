using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System117 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component282,Component408> _filter = null;
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
