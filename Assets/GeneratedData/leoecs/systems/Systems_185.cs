using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System185 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component218,Component134> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component112>())
   {
    entity.Del<Component112>();
   }
   else
   {
    entity.Replace(new Component112());
   }
  }
 }
}

}
