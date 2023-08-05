using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System286 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component46,Component29,Component179,Component77> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component365>())
   {
    q+=1;
    var com = entity.Get<Component365>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component295>())
   {
    q+=1;
    var com = entity.Get<Component295>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component98>())
   {
    q+=1;
    var com = entity.Get<Component98>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
