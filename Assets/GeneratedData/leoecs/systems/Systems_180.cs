using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System180 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component267,Component118,Component451,Component58> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component235>())
   {
    entity.Del<Component235>();
   }
   else
   {
    entity.Replace(new Component235());
   }
  }
 }
}

}
