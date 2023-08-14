using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System250 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component312,Component236,Component150,Component122> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component67>())
   {
    entity.Del<Component67>();
   }
   else
   {
    entity.Replace(new Component67());
   }
  }
 }
}

}
