using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System148 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component102,Component336,Component367> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component81>())
   {
    entity.Del<Component81>();
   }
   else
   {
    entity.Replace(new Component81());
   }
  }
 }
}

}
