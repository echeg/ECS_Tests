using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System286 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component455,Component96,Component179,Component50> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component229>())
   {
    entity.Del<Component229>();
   }
   else
   {
    entity.Replace(new Component229());
   }
  }
 }
}

}
