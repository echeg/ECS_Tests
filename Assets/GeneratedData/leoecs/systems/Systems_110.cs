using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System110 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component453,Component183> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component368>())
   {
    entity.Del<Component368>();
   }
   else
   {
    entity.Replace(new Component368());
   }
  }
 }
}

}
