using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System397 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component251> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component469>())
   {
    entity.Del<Component469>();
   }
   else
   {
    entity.Replace(new Component469());
   }
  }
 }
}

}
