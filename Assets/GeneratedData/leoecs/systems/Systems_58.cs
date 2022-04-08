using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System58 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component212> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component66>())
   {
    q+=1;
    var com = entity.Get<Component66>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component35>())
   {
    q+=1;
    var com = entity.Get<Component35>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component314>())
   {
    q+=1;
    var com = entity.Get<Component314>();
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
  }
 }
}

}
