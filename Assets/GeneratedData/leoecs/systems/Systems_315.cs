using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System315 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component286,Component40,Component130,Component404> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component40>())
   {
    q+=1;
    var com = entity.Get<Component40>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component12>())
   {
    q+=1;
    var com = entity.Get<Component12>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component138>())
   {
    q+=1;
    var com = entity.Get<Component138>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component189>())
   {
    q+=1;
    var com = entity.Get<Component189>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
