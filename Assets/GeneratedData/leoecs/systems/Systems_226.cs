using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System226 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component91,Component158> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component54>())
   {
    entity.Del<Component54>();
   }
   else
   {
    entity.Replace(new Component54());
   }
  }
 }
}

}
