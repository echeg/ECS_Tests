using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System396 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component180,Component230,Component329> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component101>())
   {
    entity.Del<Component101>();
   }
   else
   {
    entity.Replace(new Component101());
   }
  }
 }
}

}
