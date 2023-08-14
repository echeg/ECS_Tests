using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System384 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component456,Component393,Component231,Component394> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component241>())
   {
    entity.Del<Component241>();
   }
   else
   {
    entity.Replace(new Component241());
   }
  }
 }
}

}
