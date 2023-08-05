using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System337 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component434,Component497,Component237,Component424> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component271>())
   {
    q+=1;
    var com = entity.Get<Component271>();
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
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component200>())
   {
    q+=1;
    var com = entity.Get<Component200>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
