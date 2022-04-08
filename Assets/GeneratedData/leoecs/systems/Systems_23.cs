using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System23 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component225,Component94,Component161> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component70>())
   {
    q+=1;
    var com = entity.Get<Component70>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component262>())
   {
    q+=1;
    var com = entity.Get<Component262>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component183>())
   {
    q+=1;
    var com = entity.Get<Component183>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component323>())
   {
    q+=1;
    var com = entity.Get<Component323>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
