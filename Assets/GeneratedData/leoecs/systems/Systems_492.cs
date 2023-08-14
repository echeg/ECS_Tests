using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System492 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component431,Component30,Component298,Component138> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component258>())
   {
    q+=1;
    var com = entity.Get<Component258>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
