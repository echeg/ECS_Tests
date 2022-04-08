using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System53 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component469,Component138> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component453>())
   {
    q+=1;
    var com = entity.Get<Component453>();
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
   if (entity.Has<Component368>())
   {
    q+=1;
    var com = entity.Get<Component368>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component21>())
   {
    q+=1;
    var com = entity.Get<Component21>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
