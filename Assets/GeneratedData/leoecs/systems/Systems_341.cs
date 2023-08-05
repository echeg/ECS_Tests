using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System341 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component170,Component342,Component469,Component361> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component364>())
   {
    q+=1;
    var com = entity.Get<Component364>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component183>())
   {
    q+=1;
    var com = entity.Get<Component183>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component290>())
   {
    q+=1;
    var com = entity.Get<Component290>();
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
  }
 }
}

}
