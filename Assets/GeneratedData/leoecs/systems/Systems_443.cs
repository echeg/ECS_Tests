using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System443 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component205,Component104,Component232,Component105> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component126>())
   {
    q+=1;
    var com = entity.Get<Component126>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
