using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System157 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component161,Component294,Component59,Component346> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component166>())
   {
    entity.Del<Component166>();
   }
   else
   {
    entity.Replace(new Component166());
   }
  }
 }
}

}
