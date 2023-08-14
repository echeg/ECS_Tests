using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System491 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component8> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component211>())
   {
    q+=1;
    var com = entity.Get<Component211>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
