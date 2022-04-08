using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System74 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component294,Component102,Component231,Component490> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component337>())
   {
    q+=1;
    var com = entity.Get<Component337>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component262>())
   {
    q+=1;
    var com = entity.Get<Component262>();
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
   if (entity.Has<Component336>())
   {
    q+=1;
    var com = entity.Get<Component336>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
