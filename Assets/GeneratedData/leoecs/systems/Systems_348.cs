using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System348 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component70,Component22,Component386> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component332>())
   {
    entity.Del<Component332>();
   }
   else
   {
    entity.Replace(new Component332());
   }
  }
 }
}

}
