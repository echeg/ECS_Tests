using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System344 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component167> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component409>())
   {
    entity.Del<Component409>();
   }
   else
   {
    entity.Replace(new Component409());
   }
  }
 }
}

}
