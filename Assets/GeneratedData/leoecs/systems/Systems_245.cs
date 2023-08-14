using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System245 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component438,Component368> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component338>())
   {
    entity.Del<Component338>();
   }
   else
   {
    entity.Replace(new Component338());
   }
  }
 }
}

}
