using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System260 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component402,Component200,Component408> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component171>())
   {
    entity.Del<Component171>();
   }
   else
   {
    entity.Replace(new Component171());
   }
  }
 }
}

}
