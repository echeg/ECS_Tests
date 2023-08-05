using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System219 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component441> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component238>())
   {
    q+=1;
    var com = entity.Get<Component238>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component289>())
   {
    q+=1;
    var com = entity.Get<Component289>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component309>())
   {
    q+=1;
    var com = entity.Get<Component309>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component372>())
   {
    q+=1;
    var com = entity.Get<Component372>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
