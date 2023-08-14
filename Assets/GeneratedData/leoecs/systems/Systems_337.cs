using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System337 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component330,Component477,Component479> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component437>())
   {
    entity.Del<Component437>();
   }
   else
   {
    entity.Replace(new Component437());
   }
  }
 }
}

}
