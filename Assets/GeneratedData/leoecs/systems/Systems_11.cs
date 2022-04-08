using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System11 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component203,Component180,Component320,Component113> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component359>())
   {
    q+=1;
    var com = entity.Get<Component359>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component120>())
   {
    q+=1;
    var com = entity.Get<Component120>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component277>())
   {
    q+=1;
    var com = entity.Get<Component277>();
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
