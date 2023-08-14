using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System403 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component245,Component54,Component327,Component5> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component18>())
   {
    q+=1;
    var com = entity.Get<Component18>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
