using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System457 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component211> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component191>())
   {
    q+=1;
    var com = entity.Get<Component191>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
