using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System468 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component95,Component75,Component379,Component209> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component31>())
   {
    q+=1;
    var com = entity.Get<Component31>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
