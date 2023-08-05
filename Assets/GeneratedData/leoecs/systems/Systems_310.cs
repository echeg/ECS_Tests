using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System310 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component30,Component292> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component205>())
   {
    q+=1;
    var com = entity.Get<Component205>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component423>())
   {
    q+=1;
    var com = entity.Get<Component423>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component490>())
   {
    q+=1;
    var com = entity.Get<Component490>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
