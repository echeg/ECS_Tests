using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System204 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component232,Component277,Component495> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component195>())
   {
    q+=1;
    var com = entity.Get<Component195>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component78>())
   {
    q+=1;
    var com = entity.Get<Component78>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component22>())
   {
    q+=1;
    var com = entity.Get<Component22>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component423>())
   {
    q+=1;
    var com = entity.Get<Component423>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
