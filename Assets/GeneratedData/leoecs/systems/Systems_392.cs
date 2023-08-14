using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System392 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component248,Component399,Component106,Component284> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component242>())
   {
    entity.Del<Component242>();
   }
   else
   {
    entity.Replace(new Component242());
   }
  }
 }
}

}
