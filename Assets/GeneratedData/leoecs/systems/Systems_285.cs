using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System285 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component441,Component242,Component15,Component377> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component278>())
   {
    entity.Del<Component278>();
   }
   else
   {
    entity.Replace(new Component278());
   }
  }
 }
}

}
