using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System289 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component459,Component343,Component364> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component136>())
   {
    q+=1;
    var com = entity.Get<Component136>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component392>())
   {
    q+=1;
    var com = entity.Get<Component392>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component381>())
   {
    q+=1;
    var com = entity.Get<Component381>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component349>())
   {
    q+=1;
    var com = entity.Get<Component349>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
