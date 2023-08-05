using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System205 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component165,Component398,Component410> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component484>())
   {
    q+=1;
    var com = entity.Get<Component484>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component421>())
   {
    q+=1;
    var com = entity.Get<Component421>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component245>())
   {
    q+=1;
    var com = entity.Get<Component245>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component254>())
   {
    q+=1;
    var com = entity.Get<Component254>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
