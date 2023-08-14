using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System218 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component364> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component380>())
   {
    entity.Del<Component380>();
   }
   else
   {
    entity.Replace(new Component380());
   }
  }
 }
}

}
