using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System259 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component56,Component493,Component117,Component466> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component21>())
   {
    q+=1;
    var com = entity.Get<Component21>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component101>())
   {
    q+=1;
    var com = entity.Get<Component101>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component136>())
   {
    q+=1;
    var com = entity.Get<Component136>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component88>())
   {
    q+=1;
    var com = entity.Get<Component88>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
