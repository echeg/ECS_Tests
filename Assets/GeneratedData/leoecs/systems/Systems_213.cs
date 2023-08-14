using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System213 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component461,Component155,Component22,Component434> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component214>())
   {
    entity.Del<Component214>();
   }
   else
   {
    entity.Replace(new Component214());
   }
  }
 }
}

}
