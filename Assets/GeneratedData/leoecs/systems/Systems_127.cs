using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System127 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component218,Component90,Component397> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component227>())
   {
    entity.Del<Component227>();
   }
   else
   {
    entity.Replace(new Component227());
   }
  }
 }
}

}
