using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System460 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component36,Component16,Component171> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component330>())
   {
    q+=1;
    var com = entity.Get<Component330>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
