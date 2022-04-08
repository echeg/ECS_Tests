using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System26 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component390> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component333>())
   {
    q+=1;
    var com = entity.Get<Component333>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component461>())
   {
    q+=1;
    var com = entity.Get<Component461>();
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
   if (entity.Has<Component78>())
   {
    q+=1;
    var com = entity.Get<Component78>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
