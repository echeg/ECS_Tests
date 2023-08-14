using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System452 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component476,Component250,Component166,Component340> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component209>())
   {
    q+=1;
    var com = entity.Get<Component209>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
