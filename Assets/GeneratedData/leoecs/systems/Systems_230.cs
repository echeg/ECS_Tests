using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System230 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component426,Component100,Component264,Component299> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component130>())
   {
    q+=1;
    var com = entity.Get<Component130>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component403>())
   {
    q+=1;
    var com = entity.Get<Component403>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component147>())
   {
    q+=1;
    var com = entity.Get<Component147>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component255>())
   {
    q+=1;
    var com = entity.Get<Component255>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
