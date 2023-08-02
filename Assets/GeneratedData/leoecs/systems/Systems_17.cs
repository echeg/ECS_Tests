using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System17 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component323,Component261,Component466> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component320>())
   {
    q+=1;
    var com = entity.Get<Component320>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component444>())
   {
    q+=1;
    var com = entity.Get<Component444>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component307>())
   {
    q+=1;
    var com = entity.Get<Component307>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component9>())
   {
    q+=1;
    var com = entity.Get<Component9>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}