using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System221 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component381,Component344,Component422> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component396>())
   {
    q+=1;
    var com = entity.Get<Component396>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component30>())
   {
    q+=1;
    var com = entity.Get<Component30>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component485>())
   {
    q+=1;
    var com = entity.Get<Component485>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
