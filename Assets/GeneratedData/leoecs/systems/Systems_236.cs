using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System236 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component159,Component231,Component107,Component418> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component484>())
   {
    entity.Del<Component484>();
   }
   else
   {
    entity.Replace(new Component484());
   }
  }
 }
}

}
