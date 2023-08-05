using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System201 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component411,Component53,Component278> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component429>())
   {
    q+=1;
    var com = entity.Get<Component429>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component221>())
   {
    q+=1;
    var com = entity.Get<Component221>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component403>())
   {
    q+=1;
    var com = entity.Get<Component403>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component11>())
   {
    q+=1;
    var com = entity.Get<Component11>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
