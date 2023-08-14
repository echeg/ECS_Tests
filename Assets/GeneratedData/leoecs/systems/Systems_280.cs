using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System280 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component45,Component498> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component62>())
   {
    entity.Del<Component62>();
   }
   else
   {
    entity.Replace(new Component62());
   }
  }
 }
}

}
