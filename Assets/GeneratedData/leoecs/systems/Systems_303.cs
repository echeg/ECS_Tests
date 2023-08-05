using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System303 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component294,Component426,Component20,Component425> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component306>())
   {
    q+=1;
    var com = entity.Get<Component306>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component496>())
   {
    q+=1;
    var com = entity.Get<Component496>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component346>())
   {
    q+=1;
    var com = entity.Get<Component346>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
