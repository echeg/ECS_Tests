using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System261 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component22,Component344,Component77> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component375>())
   {
    entity.Del<Component375>();
   }
   else
   {
    entity.Replace(new Component375());
   }
  }
 }
}

}
