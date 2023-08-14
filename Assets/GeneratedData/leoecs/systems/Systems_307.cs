using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System307 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component174,Component332,Component154> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component127>())
   {
    entity.Del<Component127>();
   }
   else
   {
    entity.Replace(new Component127());
   }
  }
 }
}

}
