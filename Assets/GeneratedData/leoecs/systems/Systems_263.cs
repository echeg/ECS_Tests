using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System263 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46,Component440> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component434>())
   {
    q+=1;
    var com = entity.Get<Component434>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component397>())
   {
    q+=1;
    var com = entity.Get<Component397>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component248>())
   {
    q+=1;
    var com = entity.Get<Component248>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
