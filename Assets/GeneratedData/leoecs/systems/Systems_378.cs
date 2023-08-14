using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System378 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component151,Component386,Component378> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component268>())
   {
    entity.Del<Component268>();
   }
   else
   {
    entity.Replace(new Component268());
   }
  }
 }
}

}
