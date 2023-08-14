using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System488 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component101,Component52,Component80,Component470> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component247>())
   {
    q+=1;
    var com = entity.Get<Component247>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
