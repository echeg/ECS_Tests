using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System248 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component10,Component128,Component340,Component418> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component247>())
   {
    entity.Del<Component247>();
   }
   else
   {
    entity.Replace(new Component247());
   }
  }
 }
}

}
