using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System174 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component354> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component287>())
   {
    entity.Del<Component287>();
   }
   else
   {
    entity.Replace(new Component287());
   }
  }
 }
}

}
