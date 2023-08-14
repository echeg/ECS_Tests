using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System325 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component238,Component175> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component301>())
   {
    entity.Del<Component301>();
   }
   else
   {
    entity.Replace(new Component301());
   }
  }
 }
}

}
