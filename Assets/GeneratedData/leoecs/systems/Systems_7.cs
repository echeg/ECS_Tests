using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System7 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component305,Component272,Component169> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component359>())
   {
    q+=1;
    var com = entity.Get<Component359>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component407>())
   {
    q+=1;
    var com = entity.Get<Component407>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component380>())
   {
    q+=1;
    var com = entity.Get<Component380>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component483>())
   {
    q+=1;
    var com = entity.Get<Component483>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
