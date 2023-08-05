using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System199 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component86,Component474,Component255> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component37>())
   {
    entity.Del<Component37>();
   }
   else
   {
    entity.Replace(new Component37());
   }
  }
 }
}

}
