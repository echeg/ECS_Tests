using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System104 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component153,Component340,Component422> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component444>())
   {
    entity.Del<Component444>();
   }
   else
   {
    entity.Replace(new Component444());
   }
  }
 }
}

}
