using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System107 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component144,Component142,Component87> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component122>())
   {
    entity.Del<Component122>();
   }
   else
   {
    entity.Replace(new Component122());
   }
  }
 }
}

}
