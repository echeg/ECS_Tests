using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System364 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component163,Component63,Component85,Component234> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component229>())
   {
    entity.Del<Component229>();
   }
   else
   {
    entity.Replace(new Component229());
   }
  }
 }
}

}
