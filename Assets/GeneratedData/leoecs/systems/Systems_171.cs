using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System171 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component377,Component353> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component385>())
   {
    entity.Del<Component385>();
   }
   else
   {
    entity.Replace(new Component385());
   }
  }
 }
}

}
