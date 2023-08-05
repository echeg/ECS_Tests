using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System210 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component391,Component281,Component445> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component344>())
   {
    q+=1;
    var com = entity.Get<Component344>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component467>())
   {
    q+=1;
    var com = entity.Get<Component467>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component414>())
   {
    q+=1;
    var com = entity.Get<Component414>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component279>())
   {
    q+=1;
    var com = entity.Get<Component279>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
