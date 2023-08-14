using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System314 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component43,Component7> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component439>())
   {
    entity.Del<Component439>();
   }
   else
   {
    entity.Replace(new Component439());
   }
  }
 }
}

}
