using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System78 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component166,Component354> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component109>())
   {
    q+=1;
    var com = entity.Get<Component109>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component296>())
   {
    q+=1;
    var com = entity.Get<Component296>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component418>())
   {
    q+=1;
    var com = entity.Get<Component418>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component41>())
   {
    q+=1;
    var com = entity.Get<Component41>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
