using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System318 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component461,Component487,Component425> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component137>())
   {
    entity.Del<Component137>();
   }
   else
   {
    entity.Replace(new Component137());
   }
  }
 }
}

}
