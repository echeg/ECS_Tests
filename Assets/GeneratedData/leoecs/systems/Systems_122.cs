using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System122 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component145,Component478> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component366>())
   {
    entity.Del<Component366>();
   }
   else
   {
    entity.Replace(new Component366());
   }
  }
 }
}

}
