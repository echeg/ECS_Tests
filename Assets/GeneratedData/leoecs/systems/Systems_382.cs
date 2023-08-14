using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System382 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component262,Component280,Component208> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component6>())
   {
    entity.Del<Component6>();
   }
   else
   {
    entity.Replace(new Component6());
   }
  }
 }
}

}
