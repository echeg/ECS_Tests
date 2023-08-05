using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System233 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component223,Component140> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component381>())
   {
    q+=1;
    var com = entity.Get<Component381>();
   }
   else
   {
    q-=1;
   }
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
  }
 }
}

}
