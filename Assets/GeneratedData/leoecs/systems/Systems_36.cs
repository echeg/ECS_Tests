using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System36 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component448,Component231,Component224,Component288> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component53>())
   {
    q+=1;
    var com = entity.Get<Component53>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component296>())
   {
    q+=1;
    var com = entity.Get<Component296>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component326>())
   {
    q+=1;
    var com = entity.Get<Component326>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component345>())
   {
    q+=1;
    var com = entity.Get<Component345>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
