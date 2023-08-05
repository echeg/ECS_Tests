using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System255 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component420,Component278> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component174>())
   {
    q+=1;
    var com = entity.Get<Component174>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component423>())
   {
    q+=1;
    var com = entity.Get<Component423>();
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
   if (entity.Has<Component168>())
   {
    q+=1;
    var com = entity.Get<Component168>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
