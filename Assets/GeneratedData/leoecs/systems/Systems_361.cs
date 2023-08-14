using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System361 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component89,Component266,Component105,Component448> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component181>())
   {
    entity.Del<Component181>();
   }
   else
   {
    entity.Replace(new Component181());
   }
  }
 }
}

}
