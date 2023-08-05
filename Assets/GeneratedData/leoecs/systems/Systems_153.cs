using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System153 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component166,Component354> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component109>())
   {
    entity.Del<Component109>();
   }
   else
   {
    entity.Replace(new Component109());
   }
  }
 }
}

}
