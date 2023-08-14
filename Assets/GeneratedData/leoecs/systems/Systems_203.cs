using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System203 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component263,Component352> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component105>())
   {
    entity.Del<Component105>();
   }
   else
   {
    entity.Replace(new Component105());
   }
  }
 }
}

}
