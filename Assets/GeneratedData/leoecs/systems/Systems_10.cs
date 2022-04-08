using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System10 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component289,Component279> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component437>())
   {
    q+=1;
    var com = entity.Get<Component437>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component97>())
   {
    q+=1;
    var com = entity.Get<Component97>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component159>())
   {
    q+=1;
    var com = entity.Get<Component159>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component158>())
   {
    q+=1;
    var com = entity.Get<Component158>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
