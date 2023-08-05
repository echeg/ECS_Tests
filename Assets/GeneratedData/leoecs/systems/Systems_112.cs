using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System112 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component55> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component378>())
   {
    entity.Del<Component378>();
   }
   else
   {
    entity.Replace(new Component378());
   }
  }
 }
}

}
