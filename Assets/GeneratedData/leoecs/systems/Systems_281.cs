using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System281 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component271,Component410,Component489> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component231>())
   {
    entity.Del<Component231>();
   }
   else
   {
    entity.Replace(new Component231());
   }
  }
 }
}

}
