using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System84 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component372,Component307> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component39>())
   {
    q+=1;
    var com = entity.Get<Component39>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component487>())
   {
    q+=1;
    var com = entity.Get<Component487>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component355>())
   {
    q+=1;
    var com = entity.Get<Component355>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component95>())
   {
    q+=1;
    var com = entity.Get<Component95>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
