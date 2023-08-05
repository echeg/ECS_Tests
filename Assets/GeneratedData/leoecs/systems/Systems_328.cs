using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System328 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component265,Component413> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component314>())
   {
    q+=1;
    var com = entity.Get<Component314>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component407>())
   {
    q+=1;
    var com = entity.Get<Component407>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component381>())
   {
    q+=1;
    var com = entity.Get<Component381>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
