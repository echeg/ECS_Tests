using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System360 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component304> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component102>())
   {
    entity.Del<Component102>();
   }
   else
   {
    entity.Replace(new Component102());
   }
  }
 }
}

}
