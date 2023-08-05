using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System130 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component476> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component252>())
   {
    entity.Del<Component252>();
   }
   else
   {
    entity.Replace(new Component252());
   }
  }
 }
}

}
