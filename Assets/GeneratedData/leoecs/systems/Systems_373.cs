using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System373 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component278,Component227> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component318>())
   {
    entity.Del<Component318>();
   }
   else
   {
    entity.Replace(new Component318());
   }
  }
 }
}

}
