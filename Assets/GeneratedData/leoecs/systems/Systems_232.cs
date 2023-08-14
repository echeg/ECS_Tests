using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System232 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component323,Component263,Component240> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component336>())
   {
    entity.Del<Component336>();
   }
   else
   {
    entity.Replace(new Component336());
   }
  }
 }
}

}
