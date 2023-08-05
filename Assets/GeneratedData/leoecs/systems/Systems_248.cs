using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System248 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component126,Component215> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component78>())
   {
    q+=1;
    var com = entity.Get<Component78>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component123>())
   {
    q+=1;
    var com = entity.Get<Component123>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component37>())
   {
    q+=1;
    var com = entity.Get<Component37>();
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
