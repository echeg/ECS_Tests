using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System173 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component463> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component53>())
   {
    entity.Del<Component53>();
   }
   else
   {
    entity.Replace(new Component53());
   }
  }
 }
}

}
