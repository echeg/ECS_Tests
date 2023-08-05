using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System100 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component408,Component371,Component161,Component450> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component192>())
   {
    entity.Del<Component192>();
   }
   else
   {
    entity.Replace(new Component192());
   }
  }
 }
}

}
