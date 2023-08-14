using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System229 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component70,Component216> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component91>())
   {
    entity.Del<Component91>();
   }
   else
   {
    entity.Replace(new Component91());
   }
  }
 }
}

}
