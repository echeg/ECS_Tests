using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System9 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component198,Component34,Component424,Component151> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component178>())
   {
    q+=1;
    var com = entity.Get<Component178>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component2>())
   {
    q+=1;
    var com = entity.Get<Component2>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component299>())
   {
    q+=1;
    var com = entity.Get<Component299>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component443>())
   {
    q+=1;
    var com = entity.Get<Component443>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
