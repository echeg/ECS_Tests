using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System206 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component372,Component141,Component387,Component87> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component60>())
   {
    entity.Del<Component60>();
   }
   else
   {
    entity.Replace(new Component60());
   }
  }
 }
}

}
