using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System240 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component241,Component164,Component151> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component305>())
   {
    entity.Del<Component305>();
   }
   else
   {
    entity.Replace(new Component305());
   }
  }
 }
}

}
