using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System44 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component37> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component13>())
   {
    q+=1;
    var com = entity.Get<Component13>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component427>())
   {
    q+=1;
    var com = entity.Get<Component427>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component378>())
   {
    q+=1;
    var com = entity.Get<Component378>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component459>())
   {
    q+=1;
    var com = entity.Get<Component459>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
