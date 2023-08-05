using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System215 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component108,Component454,Component315> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component376>())
   {
    q+=1;
    var com = entity.Get<Component376>();
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
   if (entity.Has<Component496>())
   {
    q+=1;
    var com = entity.Get<Component496>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component173>())
   {
    q+=1;
    var com = entity.Get<Component173>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
