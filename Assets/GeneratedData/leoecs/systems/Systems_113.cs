using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System113 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component80,Component476,Component434> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component477>())
   {
    entity.Del<Component477>();
   }
   else
   {
    entity.Replace(new Component477());
   }
  }
 }
}

}
