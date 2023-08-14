using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System319 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component47,Component467> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component376>())
   {
    entity.Del<Component376>();
   }
   else
   {
    entity.Replace(new Component376());
   }
  }
 }
}

}
