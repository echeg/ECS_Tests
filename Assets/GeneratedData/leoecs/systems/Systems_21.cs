using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System21 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component242,Component52> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component82>())
   {
    q+=1;
    var com = entity.Get<Component82>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component225>())
   {
    q+=1;
    var com = entity.Get<Component225>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component380>())
   {
    q+=1;
    var com = entity.Get<Component380>();
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
  }
 }
}

}
