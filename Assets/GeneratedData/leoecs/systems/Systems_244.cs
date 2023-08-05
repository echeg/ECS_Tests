using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System244 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component465,Component92,Component229> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component356>())
   {
    q+=1;
    var com = entity.Get<Component356>();
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
   if (entity.Has<Component280>())
   {
    q+=1;
    var com = entity.Get<Component280>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component295>())
   {
    q+=1;
    var com = entity.Get<Component295>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
