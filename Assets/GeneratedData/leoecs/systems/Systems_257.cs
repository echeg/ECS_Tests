using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System257 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component255> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component335>())
   {
    q+=1;
    var com = entity.Get<Component335>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component146>())
   {
    q+=1;
    var com = entity.Get<Component146>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component473>())
   {
    q+=1;
    var com = entity.Get<Component473>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component180>())
   {
    q+=1;
    var com = entity.Get<Component180>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
