using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System176 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component192,Component133,Component248> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component235>())
   {
    entity.Del<Component235>();
   }
   else
   {
    entity.Replace(new Component235());
   }
  }
 }
}

}
