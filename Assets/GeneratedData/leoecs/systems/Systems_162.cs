using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System162 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component487> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component355>())
   {
    entity.Del<Component355>();
   }
   else
   {
    entity.Replace(new Component355());
   }
  }
 }
}

}
