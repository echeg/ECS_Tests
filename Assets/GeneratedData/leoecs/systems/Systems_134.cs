using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System134 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component31,Component499,Component60> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component3>())
   {
    entity.Del<Component3>();
   }
   else
   {
    entity.Replace(new Component3());
   }
  }
 }
}

}
