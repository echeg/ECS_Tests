using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System33 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component195,Component118,Component364> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component95>())
   {
    q+=1;
    var com = entity.Get<Component95>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component103>())
   {
    q+=1;
    var com = entity.Get<Component103>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component7>())
   {
    q+=1;
    var com = entity.Get<Component7>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component200>())
   {
    q+=1;
    var com = entity.Get<Component200>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}