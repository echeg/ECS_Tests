using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System291 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component414,Component154,Component491,Component34> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component477>())
   {
    q+=1;
    var com = entity.Get<Component477>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component311>())
   {
    q+=1;
    var com = entity.Get<Component311>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component43>())
   {
    q+=1;
    var com = entity.Get<Component43>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
