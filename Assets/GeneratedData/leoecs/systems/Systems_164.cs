using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System164 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component360> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component143>())
   {
    entity.Del<Component143>();
   }
   else
   {
    entity.Replace(new Component143());
   }
  }
 }
}

}
