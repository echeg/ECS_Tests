using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System324 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component136,Component384> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component446>())
   {
    entity.Del<Component446>();
   }
   else
   {
    entity.Replace(new Component446());
   }
  }
 }
}

}
