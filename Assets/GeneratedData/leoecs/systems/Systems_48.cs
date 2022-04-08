using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System48 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component161,Component450,Component192> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component41>())
   {
    q+=1;
    var com = entity.Get<Component41>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component237>())
   {
    q+=1;
    var com = entity.Get<Component237>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component455>())
   {
    q+=1;
    var com = entity.Get<Component455>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component23>())
   {
    q+=1;
    var com = entity.Get<Component23>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
