using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System371 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component324,Component344,Component201,Component209> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component361>())
   {
    entity.Del<Component361>();
   }
   else
   {
    entity.Replace(new Component361());
   }
  }
 }
}

}
