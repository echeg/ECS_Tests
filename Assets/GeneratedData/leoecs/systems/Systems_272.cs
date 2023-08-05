using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System272 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component144> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component86>())
   {
    q+=1;
    var com = entity.Get<Component86>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component499>())
   {
    q+=1;
    var com = entity.Get<Component499>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component392>())
   {
    q+=1;
    var com = entity.Get<Component392>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component478>())
   {
    q+=1;
    var com = entity.Get<Component478>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
