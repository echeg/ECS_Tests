using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System161 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component498,Component353,Component195,Component372> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component307>())
   {
    entity.Del<Component307>();
   }
   else
   {
    entity.Replace(new Component307());
   }
  }
 }
}

}
