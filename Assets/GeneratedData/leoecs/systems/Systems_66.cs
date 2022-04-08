using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System66 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component15,Component418> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component143>())
   {
    q+=1;
    var com = entity.Get<Component143>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component283>())
   {
    q+=1;
    var com = entity.Get<Component283>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component31>())
   {
    q+=1;
    var com = entity.Get<Component31>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component499>())
   {
    q+=1;
    var com = entity.Get<Component499>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
