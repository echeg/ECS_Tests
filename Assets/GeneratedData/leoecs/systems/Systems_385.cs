using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System385 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component201,Component279,Component400> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component459>())
   {
    entity.Del<Component459>();
   }
   else
   {
    entity.Replace(new Component459());
   }
  }
 }
}

}
