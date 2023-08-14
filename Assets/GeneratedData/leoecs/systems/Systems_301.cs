using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System301 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component178> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component258>())
   {
    entity.Del<Component258>();
   }
   else
   {
    entity.Replace(new Component258());
   }
  }
 }
}

}
