using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System295 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3,Component457,Component58,Component259> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component213>())
   {
    entity.Del<Component213>();
   }
   else
   {
    entity.Replace(new Component213());
   }
  }
 }
}

}
