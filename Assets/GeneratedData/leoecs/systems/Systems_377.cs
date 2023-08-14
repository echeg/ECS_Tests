using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System377 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component493> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component408>())
   {
    entity.Del<Component408>();
   }
   else
   {
    entity.Replace(new Component408());
   }
  }
 }
}

}
