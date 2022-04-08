using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System25 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component488> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component434>())
   {
    q+=1;
    var com = entity.Get<Component434>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component260>())
   {
    q+=1;
    var com = entity.Get<Component260>();
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
   if (entity.Has<Component328>())
   {
    q+=1;
    var com = entity.Get<Component328>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
