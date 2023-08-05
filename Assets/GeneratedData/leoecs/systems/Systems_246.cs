using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System246 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46,Component340> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component111>())
   {
    q+=1;
    var com = entity.Get<Component111>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component457>())
   {
    q+=1;
    var com = entity.Get<Component457>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component424>())
   {
    q+=1;
    var com = entity.Get<Component424>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component247>())
   {
    q+=1;
    var com = entity.Get<Component247>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
