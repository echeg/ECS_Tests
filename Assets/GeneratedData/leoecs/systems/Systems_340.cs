using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System340 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component65> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component333>())
   {
    entity.Del<Component333>();
   }
   else
   {
    entity.Replace(new Component333());
   }
  }
 }
}

}
