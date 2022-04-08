using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System24 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component335,Component265,Component256> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component464>())
   {
    q+=1;
    var com = entity.Get<Component464>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component208>())
   {
    q+=1;
    var com = entity.Get<Component208>();
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
   if (entity.Has<Component371>())
   {
    q+=1;
    var com = entity.Get<Component371>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
