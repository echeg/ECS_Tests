using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System336 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component90> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component428>())
   {
    entity.Del<Component428>();
   }
   else
   {
    entity.Replace(new Component428());
   }
  }
 }
}

}
