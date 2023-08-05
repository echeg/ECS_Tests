using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System258 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component373> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component338>())
   {
    q+=1;
    var com = entity.Get<Component338>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component118>())
   {
    q+=1;
    var com = entity.Get<Component118>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component489>())
   {
    q+=1;
    var com = entity.Get<Component489>();
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
  }
 }
}

}
