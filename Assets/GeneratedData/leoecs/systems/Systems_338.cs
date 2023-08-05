using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System338 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component274,Component175> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component179>())
   {
    q+=1;
    var com = entity.Get<Component179>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component494>())
   {
    q+=1;
    var com = entity.Get<Component494>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component249>())
   {
    q+=1;
    var com = entity.Get<Component249>();
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
  }
 }
}

}
