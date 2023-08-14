using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System284 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component474,Component334,Component374,Component179> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component466>())
   {
    entity.Del<Component466>();
   }
   else
   {
    entity.Replace(new Component466());
   }
  }
 }
}

}
