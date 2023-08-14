using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System269 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component474> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component443>())
   {
    entity.Del<Component443>();
   }
   else
   {
    entity.Replace(new Component443());
   }
  }
 }
}

}
