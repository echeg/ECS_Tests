using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System338 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component468,Component358,Component379> _filter = null;
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
