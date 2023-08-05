using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System220 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component166,Component43> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component435>())
   {
    q+=1;
    var com = entity.Get<Component435>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component263>())
   {
    q+=1;
    var com = entity.Get<Component263>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component478>())
   {
    q+=1;
    var com = entity.Get<Component478>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component473>())
   {
    q+=1;
    var com = entity.Get<Component473>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
