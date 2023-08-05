using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System284 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component345> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component187>())
   {
    q+=1;
    var com = entity.Get<Component187>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component237>())
   {
    q+=1;
    var com = entity.Get<Component237>();
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
   if (entity.Has<Component27>())
   {
    q+=1;
    var com = entity.Get<Component27>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
