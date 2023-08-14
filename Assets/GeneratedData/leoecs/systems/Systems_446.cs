using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System446 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component416,Component194,Component392,Component317> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component224>())
   {
    q+=1;
    var com = entity.Get<Component224>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
