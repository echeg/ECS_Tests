using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System177 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component266,Component355,Component455,Component269> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component194>())
   {
    entity.Del<Component194>();
   }
   else
   {
    entity.Replace(new Component194());
   }
  }
 }
}

}
