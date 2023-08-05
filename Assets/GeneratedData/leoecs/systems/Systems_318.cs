using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System318 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component435,Component28,Component342> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component86>())
   {
    q+=1;
    var com = entity.Get<Component86>();
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
   if (entity.Has<Component125>())
   {
    q+=1;
    var com = entity.Get<Component125>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component432>())
   {
    q+=1;
    var com = entity.Get<Component432>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
