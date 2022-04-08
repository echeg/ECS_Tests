using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System52 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component122> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component25>())
   {
    q+=1;
    var com = entity.Get<Component25>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component226>())
   {
    q+=1;
    var com = entity.Get<Component226>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component94>())
   {
    q+=1;
    var com = entity.Get<Component94>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component100>())
   {
    q+=1;
    var com = entity.Get<Component100>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
