using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System143 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component178> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component299>())
   {
    entity.Del<Component299>();
   }
   else
   {
    entity.Replace(new Component299());
   }
  }
 }
}

}
