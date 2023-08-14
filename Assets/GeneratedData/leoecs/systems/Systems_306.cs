using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System306 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component447,Component215,Component374> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component499>())
   {
    entity.Del<Component499>();
   }
   else
   {
    entity.Replace(new Component499());
   }
  }
 }
}

}
