using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System202 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component401> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component309>())
   {
    q+=1;
    var com = entity.Get<Component309>();
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
   if (entity.Has<Component341>())
   {
    q+=1;
    var com = entity.Get<Component341>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component179>())
   {
    q+=1;
    var com = entity.Get<Component179>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
