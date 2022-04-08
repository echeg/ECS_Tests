using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System83 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component88,Component297> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component219>())
   {
    q+=1;
    var com = entity.Get<Component219>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component392>())
   {
    q+=1;
    var com = entity.Get<Component392>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component498>())
   {
    q+=1;
    var com = entity.Get<Component498>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component353>())
   {
    q+=1;
    var com = entity.Get<Component353>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
