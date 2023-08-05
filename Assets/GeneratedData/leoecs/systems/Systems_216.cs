using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System216 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component407> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component47>())
   {
    q+=1;
    var com = entity.Get<Component47>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component142>())
   {
    q+=1;
    var com = entity.Get<Component142>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component328>())
   {
    q+=1;
    var com = entity.Get<Component328>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component136>())
   {
    q+=1;
    var com = entity.Get<Component136>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
