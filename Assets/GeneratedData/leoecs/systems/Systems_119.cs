using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System119 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component142,Component24> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component212>())
   {
    entity.Del<Component212>();
   }
   else
   {
    entity.Replace(new Component212());
   }
  }
 }
}

}
