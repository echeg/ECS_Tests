using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System325 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component123,Component348> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component423>())
   {
    q+=1;
    var com = entity.Get<Component423>();
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
   if (entity.Has<Component318>())
   {
    q+=1;
    var com = entity.Get<Component318>();
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
  }
 }
}

}
