using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System45 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component45,Component433,Component98,Component256> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component50>())
   {
    q+=1;
    var com = entity.Get<Component50>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component331>())
   {
    q+=1;
    var com = entity.Get<Component331>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component11>())
   {
    q+=1;
    var com = entity.Get<Component11>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component375>())
   {
    q+=1;
    var com = entity.Get<Component375>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}