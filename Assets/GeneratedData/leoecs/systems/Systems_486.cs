using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System486 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component295,Component64,Component352,Component251> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component432>())
   {
    q+=1;
    var com = entity.Get<Component432>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
