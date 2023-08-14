using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System227 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component64> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component427>())
   {
    entity.Del<Component427>();
   }
   else
   {
    entity.Replace(new Component427());
   }
  }
 }
}

}
