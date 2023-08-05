using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System114 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component360> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component115>())
   {
    entity.Del<Component115>();
   }
   else
   {
    entity.Replace(new Component115());
   }
  }
 }
}

}
