using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System35 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component296,Component271,Component276> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component460>())
   {
    q+=1;
    var com = entity.Get<Component460>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component116>())
   {
    q+=1;
    var com = entity.Get<Component116>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component146>())
   {
    q+=1;
    var com = entity.Get<Component146>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
