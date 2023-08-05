using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System322 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component479> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component20>())
   {
    q+=1;
    var com = entity.Get<Component20>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component456>())
   {
    q+=1;
    var com = entity.Get<Component456>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component177>())
   {
    q+=1;
    var com = entity.Get<Component177>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component124>())
   {
    q+=1;
    var com = entity.Get<Component124>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
