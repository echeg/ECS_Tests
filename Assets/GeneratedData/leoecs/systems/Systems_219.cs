using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System219 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component53,Component499> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component419>())
   {
    entity.Del<Component419>();
   }
   else
   {
    entity.Replace(new Component419());
   }
  }
 }
}

}
