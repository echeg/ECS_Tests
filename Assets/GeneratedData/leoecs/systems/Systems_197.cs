using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System197 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component298,Component33,Component471> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component1>())
   {
    entity.Del<Component1>();
   }
   else
   {
    entity.Replace(new Component1());
   }
  }
 }
}

}
