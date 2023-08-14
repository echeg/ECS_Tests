using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System304 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component455>())
   {
    entity.Del<Component455>();
   }
   else
   {
    entity.Replace(new Component455());
   }
  }
 }
}

}
