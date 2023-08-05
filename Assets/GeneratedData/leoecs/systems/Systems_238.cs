using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System238 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component338,Component118,Component489> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component30>())
   {
    q+=1;
    var com = entity.Get<Component30>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component420>())
   {
    q+=1;
    var com = entity.Get<Component420>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component56>())
   {
    q+=1;
    var com = entity.Get<Component56>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component493>())
   {
    q+=1;
    var com = entity.Get<Component493>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
