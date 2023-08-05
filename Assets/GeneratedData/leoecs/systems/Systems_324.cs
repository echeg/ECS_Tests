using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System324 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component100> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component358>())
   {
    q+=1;
    var com = entity.Get<Component358>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component99>())
   {
    q+=1;
    var com = entity.Get<Component99>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component21>())
   {
    q+=1;
    var com = entity.Get<Component21>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component342>())
   {
    q+=1;
    var com = entity.Get<Component342>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
