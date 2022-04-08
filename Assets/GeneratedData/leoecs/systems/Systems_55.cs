using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System55 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component434,Component477,Component46,Component360> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component109>())
   {
    q+=1;
    var com = entity.Get<Component109>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component293>())
   {
    q+=1;
    var com = entity.Get<Component293>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component481>())
   {
    q+=1;
    var com = entity.Get<Component481>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
