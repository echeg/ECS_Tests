using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System376 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component12,Component315,Component253> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component467>())
   {
    entity.Del<Component467>();
   }
   else
   {
    entity.Replace(new Component467());
   }
  }
 }
}

}
