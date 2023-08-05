using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System291 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component227,Component419,Component33> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component475>())
   {
    q+=1;
    var com = entity.Get<Component475>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component256>())
   {
    q+=1;
    var com = entity.Get<Component256>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component364>())
   {
    q+=1;
    var com = entity.Get<Component364>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component418>())
   {
    q+=1;
    var com = entity.Get<Component418>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
