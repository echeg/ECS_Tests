using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System211 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component179,Component304> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component91>())
   {
    entity.Del<Component91>();
   }
   else
   {
    entity.Replace(new Component91());
   }
  }
 }
}

}
