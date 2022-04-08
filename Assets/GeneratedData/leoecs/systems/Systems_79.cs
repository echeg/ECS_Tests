using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System79 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component76,Component462,Component139> _filter = null;
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
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component426>())
   {
    q+=1;
    var com = entity.Get<Component426>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component261>())
   {
    q+=1;
    var com = entity.Get<Component261>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
