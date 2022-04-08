using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System71 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component27,Component408> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component118>())
   {
    q+=1;
    var com = entity.Get<Component118>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component178>())
   {
    q+=1;
    var com = entity.Get<Component178>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component299>())
   {
    q+=1;
    var com = entity.Get<Component299>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
