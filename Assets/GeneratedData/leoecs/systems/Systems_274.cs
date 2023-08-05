using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System274 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component413,Component249,Component318,Component114> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component180>())
   {
    q+=1;
    var com = entity.Get<Component180>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component4>())
   {
    q+=1;
    var com = entity.Get<Component4>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component60>())
   {
    q+=1;
    var com = entity.Get<Component60>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component308>())
   {
    q+=1;
    var com = entity.Get<Component308>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
