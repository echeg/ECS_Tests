using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System30 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component443,Component48> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component462>())
   {
    q+=1;
    var com = entity.Get<Component462>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component224>())
   {
    q+=1;
    var com = entity.Get<Component224>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component203>())
   {
    q+=1;
    var com = entity.Get<Component203>();
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
  }
 }
}

}
