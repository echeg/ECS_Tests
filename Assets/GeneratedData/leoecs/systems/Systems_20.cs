using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System20 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component94,Component261> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component456>())
   {
    q+=1;
    var com = entity.Get<Component456>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component373>())
   {
    q+=1;
    var com = entity.Get<Component373>();
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
   if (entity.Has<Component129>())
   {
    q+=1;
    var com = entity.Get<Component129>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
