using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System274 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component401,Component246> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component492>())
   {
    entity.Del<Component492>();
   }
   else
   {
    entity.Replace(new Component492());
   }
  }
 }
}

}
