using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System340 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component469> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component200>())
   {
    q+=1;
    var com = entity.Get<Component200>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component235>())
   {
    q+=1;
    var com = entity.Get<Component235>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component253>())
   {
    q+=1;
    var com = entity.Get<Component253>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
