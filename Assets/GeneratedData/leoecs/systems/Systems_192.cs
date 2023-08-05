using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System192 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component182> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component57>())
   {
    entity.Del<Component57>();
   }
   else
   {
    entity.Replace(new Component57());
   }
  }
 }
}

}
