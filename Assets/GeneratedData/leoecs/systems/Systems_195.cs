using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System195 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component116,Component82,Component106,Component419> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component116>())
   {
    entity.Del<Component116>();
   }
   else
   {
    entity.Replace(new Component116());
   }
  }
 }
}

}
