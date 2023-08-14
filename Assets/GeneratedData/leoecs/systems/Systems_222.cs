using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System222 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component235> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component294>())
   {
    entity.Del<Component294>();
   }
   else
   {
    entity.Replace(new Component294());
   }
  }
 }
}

}
