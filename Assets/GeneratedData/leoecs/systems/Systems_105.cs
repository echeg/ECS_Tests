using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System105 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component11,Component46,Component340> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component398>())
   {
    entity.Del<Component398>();
   }
   else
   {
    entity.Replace(new Component398());
   }
  }
 }
}

}
