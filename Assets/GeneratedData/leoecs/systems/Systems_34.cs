using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System34 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component450,Component467,Component155,Component407> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component188>())
   {
    q+=1;
    var com = entity.Get<Component188>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component217>())
   {
    q+=1;
    var com = entity.Get<Component217>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component362>())
   {
    q+=1;
    var com = entity.Get<Component362>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
