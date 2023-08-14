using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System272 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component68,Component177,Component126> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component32>())
   {
    entity.Del<Component32>();
   }
   else
   {
    entity.Replace(new Component32());
   }
  }
 }
}

}
