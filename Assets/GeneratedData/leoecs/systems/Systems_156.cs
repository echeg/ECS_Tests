using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System156 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component143,Component324> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component482>())
   {
    entity.Del<Component482>();
   }
   else
   {
    entity.Replace(new Component482());
   }
  }
 }
}

}
