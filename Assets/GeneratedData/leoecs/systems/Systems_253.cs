using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System253 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component140,Component381> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component47>())
   {
    q+=1;
    var com = entity.Get<Component47>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component271>())
   {
    q+=1;
    var com = entity.Get<Component271>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component186>())
   {
    q+=1;
    var com = entity.Get<Component186>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component107>())
   {
    q+=1;
    var com = entity.Get<Component107>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
