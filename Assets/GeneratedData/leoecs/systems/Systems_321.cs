using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System321 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component199,Component482,Component43,Component49> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component215>())
   {
    entity.Del<Component215>();
   }
   else
   {
    entity.Replace(new Component215());
   }
  }
 }
}

}
