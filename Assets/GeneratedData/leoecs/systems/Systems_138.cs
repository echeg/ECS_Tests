using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System138 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component453,Component413> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component187>())
   {
    entity.Del<Component187>();
   }
   else
   {
    entity.Replace(new Component187());
   }
  }
 }
}

}
