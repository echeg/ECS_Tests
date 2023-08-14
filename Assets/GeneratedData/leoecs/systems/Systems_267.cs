using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System267 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component276,Component224> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component223>())
   {
    entity.Del<Component223>();
   }
   else
   {
    entity.Replace(new Component223());
   }
  }
 }
}

}
