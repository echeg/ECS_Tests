using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System253 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component430,Component98> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component286>())
   {
    q+=1;
    var com = entity.Get<Component286>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component439>())
   {
    q+=1;
    var com = entity.Get<Component439>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component206>())
   {
    q+=1;
    var com = entity.Get<Component206>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component354>())
   {
    q+=1;
    var com = entity.Get<Component354>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
