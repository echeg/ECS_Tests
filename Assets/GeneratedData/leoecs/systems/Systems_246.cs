using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System246 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component277> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component73>())
   {
    entity.Del<Component73>();
   }
   else
   {
    entity.Replace(new Component73());
   }
  }
 }
}

}
