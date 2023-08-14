using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System249 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component250,Component106> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component95>())
   {
    entity.Del<Component95>();
   }
   else
   {
    entity.Replace(new Component95());
   }
  }
 }
}

}
