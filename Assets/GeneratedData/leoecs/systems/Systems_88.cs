using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System88 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component307,Component98,Component187,Component39> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component127>())
   {
    q+=1;
    var com = entity.Get<Component127>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component377>())
   {
    q+=1;
    var com = entity.Get<Component377>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component353>())
   {
    q+=1;
    var com = entity.Get<Component353>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component385>())
   {
    q+=1;
    var com = entity.Get<Component385>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
