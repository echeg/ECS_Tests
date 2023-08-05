using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System150 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component40,Component209,Component271> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component335>())
   {
    entity.Del<Component335>();
   }
   else
   {
    entity.Replace(new Component335());
   }
  }
 }
}

}
