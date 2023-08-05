using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System323 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component278,Component468,Component11,Component170> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component51>())
   {
    q+=1;
    var com = entity.Get<Component51>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component428>())
   {
    q+=1;
    var com = entity.Get<Component428>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component73>())
   {
    q+=1;
    var com = entity.Get<Component73>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component275>())
   {
    q+=1;
    var com = entity.Get<Component275>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
