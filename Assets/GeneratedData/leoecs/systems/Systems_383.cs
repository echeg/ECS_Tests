using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System383 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component44> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component331>())
   {
    entity.Del<Component331>();
   }
   else
   {
    entity.Replace(new Component331());
   }
  }
 }
}

}
