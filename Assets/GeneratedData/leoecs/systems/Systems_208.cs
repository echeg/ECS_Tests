using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System208 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component41,Component430> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component77>())
   {
    entity.Del<Component77>();
   }
   else
   {
    entity.Replace(new Component77());
   }
  }
 }
}

}
