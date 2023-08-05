using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System228 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component315,Component175> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component164>())
   {
    q+=1;
    var com = entity.Get<Component164>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component64>())
   {
    q+=1;
    var com = entity.Get<Component64>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component99>())
   {
    q+=1;
    var com = entity.Get<Component99>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
