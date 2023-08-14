using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System346 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component325,Component84,Component484,Component311> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component350>())
   {
    entity.Del<Component350>();
   }
   else
   {
    entity.Replace(new Component350());
   }
  }
 }
}

}
