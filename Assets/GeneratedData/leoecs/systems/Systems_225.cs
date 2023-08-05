using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System225 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component499,Component120> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component184>())
   {
    q+=1;
    var com = entity.Get<Component184>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component52>())
   {
    q+=1;
    var com = entity.Get<Component52>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component409>())
   {
    q+=1;
    var com = entity.Get<Component409>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component28>())
   {
    q+=1;
    var com = entity.Get<Component28>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
