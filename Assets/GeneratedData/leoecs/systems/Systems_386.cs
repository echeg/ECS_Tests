using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System386 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component12,Component254,Component481> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component275>())
   {
    entity.Del<Component275>();
   }
   else
   {
    entity.Replace(new Component275());
   }
  }
 }
}

}
