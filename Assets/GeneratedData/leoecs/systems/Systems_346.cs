using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System346 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component314,Component315,Component310> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component459>())
   {
    q+=1;
    var com = entity.Get<Component459>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component125>())
   {
    q+=1;
    var com = entity.Get<Component125>();
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
   if (entity.Has<Component60>())
   {
    q+=1;
    var com = entity.Get<Component60>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
