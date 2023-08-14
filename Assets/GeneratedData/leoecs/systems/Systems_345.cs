using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System345 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component76,Component363,Component51,Component298> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component76>())
   {
    entity.Del<Component76>();
   }
   else
   {
    entity.Replace(new Component76());
   }
  }
 }
}

}
