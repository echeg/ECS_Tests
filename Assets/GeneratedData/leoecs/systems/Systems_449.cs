using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System449 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component375,Component66,Component440> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component397>())
   {
    q+=1;
    var com = entity.Get<Component397>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
