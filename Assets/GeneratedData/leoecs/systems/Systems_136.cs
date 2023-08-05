using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System136 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component118> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component42>())
   {
    entity.Del<Component42>();
   }
   else
   {
    entity.Replace(new Component42());
   }
  }
 }
}

}
