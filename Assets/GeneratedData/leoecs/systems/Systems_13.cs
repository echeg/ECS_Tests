using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System13 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component176,Component131,Component338,Component213> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component114>())
   {
    q+=1;
    var com = entity.Get<Component114>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component193>())
   {
    q+=1;
    var com = entity.Get<Component193>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component127>())
   {
    q+=1;
    var com = entity.Get<Component127>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
