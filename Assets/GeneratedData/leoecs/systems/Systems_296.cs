using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System296 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component207,Component95> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component234>())
   {
    q+=1;
    var com = entity.Get<Component234>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component492>())
   {
    q+=1;
    var com = entity.Get<Component492>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component215>())
   {
    q+=1;
    var com = entity.Get<Component215>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component464>())
   {
    q+=1;
    var com = entity.Get<Component464>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
