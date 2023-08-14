using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System462 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component102,Component35,Component356,Component260> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component305>())
   {
    q+=1;
    var com = entity.Get<Component305>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
