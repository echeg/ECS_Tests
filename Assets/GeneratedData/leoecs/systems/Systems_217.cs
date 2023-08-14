using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System217 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component239,Component266> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component256>())
   {
    entity.Del<Component256>();
   }
   else
   {
    entity.Replace(new Component256());
   }
  }
 }
}

}
