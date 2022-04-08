using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System95 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component408,Component12,Component157> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component224>())
   {
    q+=1;
    var com = entity.Get<Component224>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component325>())
   {
    q+=1;
    var com = entity.Get<Component325>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component347>())
   {
    q+=1;
    var com = entity.Get<Component347>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component494>())
   {
    q+=1;
    var com = entity.Get<Component494>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
