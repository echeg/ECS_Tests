using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System335 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component417,Component379,Component29> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component135>())
   {
    entity.Del<Component135>();
   }
   else
   {
    entity.Replace(new Component135());
   }
  }
 }
}

}
