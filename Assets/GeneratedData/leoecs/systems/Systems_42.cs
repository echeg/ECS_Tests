using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System42 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component265,Component127,Component196,Component450> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component367>())
   {
    q+=1;
    var com = entity.Get<Component367>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component209>())
   {
    q+=1;
    var com = entity.Get<Component209>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component306>())
   {
    q+=1;
    var com = entity.Get<Component306>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component394>())
   {
    q+=1;
    var com = entity.Get<Component394>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
