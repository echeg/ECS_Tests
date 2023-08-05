using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System261 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component479,Component122,Component138,Component43> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component144>())
   {
    q+=1;
    var com = entity.Get<Component144>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component64>())
   {
    q+=1;
    var com = entity.Get<Component64>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component288>())
   {
    q+=1;
    var com = entity.Get<Component288>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component71>())
   {
    q+=1;
    var com = entity.Get<Component71>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
