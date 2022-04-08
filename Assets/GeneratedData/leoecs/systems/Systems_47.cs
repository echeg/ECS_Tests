using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System47 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component233> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component316>())
   {
    q+=1;
    var com = entity.Get<Component316>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component357>())
   {
    q+=1;
    var com = entity.Get<Component357>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component422>())
   {
    q+=1;
    var com = entity.Get<Component422>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component408>())
   {
    q+=1;
    var com = entity.Get<Component408>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
