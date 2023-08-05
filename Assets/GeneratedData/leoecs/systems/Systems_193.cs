using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System193 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component61,Component438,Component413,Component433> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component452>())
   {
    entity.Del<Component452>();
   }
   else
   {
    entity.Replace(new Component452());
   }
  }
 }
}

}
