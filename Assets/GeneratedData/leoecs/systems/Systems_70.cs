using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System70 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component136,Component78> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component169>())
   {
    q+=1;
    var com = entity.Get<Component169>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component203>())
   {
    q+=1;
    var com = entity.Get<Component203>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component61>())
   {
    q+=1;
    var com = entity.Get<Component61>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component149>())
   {
    q+=1;
    var com = entity.Get<Component149>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
