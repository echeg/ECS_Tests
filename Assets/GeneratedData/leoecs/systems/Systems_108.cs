using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System108 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component226> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component94>())
   {
    entity.Del<Component94>();
   }
   else
   {
    entity.Replace(new Component94());
   }
  }
 }
}

}
