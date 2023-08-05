using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System115 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component293> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component481>())
   {
    entity.Del<Component481>();
   }
   else
   {
    entity.Replace(new Component481());
   }
  }
 }
}

}
