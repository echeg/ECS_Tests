using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System280 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component338,Component374,Component423> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component424>())
   {
    q+=1;
    var com = entity.Get<Component424>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component354>())
   {
    q+=1;
    var com = entity.Get<Component354>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component337>())
   {
    q+=1;
    var com = entity.Get<Component337>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component126>())
   {
    q+=1;
    var com = entity.Get<Component126>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
