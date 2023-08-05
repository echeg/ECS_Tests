using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System172 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component53,Component391,Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component347>())
   {
    entity.Del<Component347>();
   }
   else
   {
    entity.Replace(new Component347());
   }
  }
 }
}

}
