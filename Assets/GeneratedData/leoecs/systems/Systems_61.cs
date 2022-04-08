using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System61 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component495,Component464> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component50>())
   {
    q+=1;
    var com = entity.Get<Component50>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component116>())
   {
    q+=1;
    var com = entity.Get<Component116>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component171>())
   {
    q+=1;
    var com = entity.Get<Component171>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component422>())
   {
    q+=1;
    var com = entity.Get<Component422>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
