using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System367 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component34,Component258,Component141,Component421> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component160>())
   {
    entity.Del<Component160>();
   }
   else
   {
    entity.Replace(new Component160());
   }
  }
 }
}

}
