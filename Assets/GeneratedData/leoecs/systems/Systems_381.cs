using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System381 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component196,Component320> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component352>())
   {
    entity.Del<Component352>();
   }
   else
   {
    entity.Replace(new Component352());
   }
  }
 }
}

}
