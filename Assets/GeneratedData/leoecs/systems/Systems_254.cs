using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System254 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component251,Component142,Component198,Component214> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component283>())
   {
    q+=1;
    var com = entity.Get<Component283>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component184>())
   {
    q+=1;
    var com = entity.Get<Component184>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component270>())
   {
    q+=1;
    var com = entity.Get<Component270>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component102>())
   {
    q+=1;
    var com = entity.Get<Component102>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
