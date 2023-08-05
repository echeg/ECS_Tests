using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System280 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component278> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component464>())
   {
    q+=1;
    var com = entity.Get<Component464>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component211>())
   {
    q+=1;
    var com = entity.Get<Component211>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component416>())
   {
    q+=1;
    var com = entity.Get<Component416>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component270>())
   {
    q+=1;
    var com = entity.Get<Component270>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
