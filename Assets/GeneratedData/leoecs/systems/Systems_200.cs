using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System200 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component183> _filter = null;
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
   if (entity.Has<Component450>())
   {
    q+=1;
    var com = entity.Get<Component450>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component140>())
   {
    q+=1;
    var com = entity.Get<Component140>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component33>())
   {
    q+=1;
    var com = entity.Get<Component33>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
