using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System410 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component412,Component462> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component366>())
   {
    q+=1;
    var com = entity.Get<Component366>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
