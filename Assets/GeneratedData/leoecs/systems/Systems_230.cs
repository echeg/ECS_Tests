using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System230 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component122,Component3> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component471>())
   {
    entity.Del<Component471>();
   }
   else
   {
    entity.Replace(new Component471());
   }
  }
 }
}

}
