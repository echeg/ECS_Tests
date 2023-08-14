using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System354 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component454,Component210> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component377>())
   {
    entity.Del<Component377>();
   }
   else
   {
    entity.Replace(new Component377());
   }
  }
 }
}

}
