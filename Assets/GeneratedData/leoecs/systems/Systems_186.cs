using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System186 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component232> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component325>())
   {
    entity.Del<Component325>();
   }
   else
   {
    entity.Replace(new Component325());
   }
  }
 }
}

}
