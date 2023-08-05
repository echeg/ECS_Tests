using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System305 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component245,Component392,Component447,Component204> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component393>())
   {
    q+=1;
    var com = entity.Get<Component393>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component271>())
   {
    q+=1;
    var com = entity.Get<Component271>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component264>())
   {
    q+=1;
    var com = entity.Get<Component264>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component133>())
   {
    q+=1;
    var com = entity.Get<Component133>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
