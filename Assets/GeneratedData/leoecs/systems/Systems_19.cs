using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System19 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component261,Component174,Component288,Component291> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component99>())
   {
    q+=1;
    var com = entity.Get<Component99>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component366>())
   {
    q+=1;
    var com = entity.Get<Component366>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component400>())
   {
    q+=1;
    var com = entity.Get<Component400>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component114>())
   {
    q+=1;
    var com = entity.Get<Component114>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
