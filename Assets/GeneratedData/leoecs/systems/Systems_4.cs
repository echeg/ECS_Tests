using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System4 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component48,Component485,Component92,Component283> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component218>())
   {
    q+=1;
    var com = entity.Get<Component218>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component27>())
   {
    q+=1;
    var com = entity.Get<Component27>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component157>())
   {
    q+=1;
    var com = entity.Get<Component157>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component166>())
   {
    q+=1;
    var com = entity.Get<Component166>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
