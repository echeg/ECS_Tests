using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System315 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component493> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component75>())
   {
    entity.Del<Component75>();
   }
   else
   {
    entity.Replace(new Component75());
   }
  }
 }
}

}
