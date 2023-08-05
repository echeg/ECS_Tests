using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System334 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component249> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component226>())
   {
    q+=1;
    var com = entity.Get<Component226>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component150>())
   {
    q+=1;
    var com = entity.Get<Component150>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component224>())
   {
    q+=1;
    var com = entity.Get<Component224>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component96>())
   {
    q+=1;
    var com = entity.Get<Component96>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
