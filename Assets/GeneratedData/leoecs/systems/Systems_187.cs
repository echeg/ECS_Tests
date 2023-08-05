using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System187 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component206,Component107,Component242> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component240>())
   {
    entity.Del<Component240>();
   }
   else
   {
    entity.Replace(new Component240());
   }
  }
 }
}

}
