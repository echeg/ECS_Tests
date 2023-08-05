using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System277 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component381,Component456,Component309> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component218>())
   {
    q+=1;
    var com = entity.Get<Component218>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component95>())
   {
    q+=1;
    var com = entity.Get<Component95>();
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
   if (entity.Has<Component72>())
   {
    q+=1;
    var com = entity.Get<Component72>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
