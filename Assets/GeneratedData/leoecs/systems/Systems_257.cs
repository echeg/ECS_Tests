using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System257 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component140,Component126> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component38>())
   {
    q+=1;
    var com = entity.Get<Component38>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component26>())
   {
    q+=1;
    var com = entity.Get<Component26>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component102>())
   {
    q+=1;
    var com = entity.Get<Component102>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component138>())
   {
    q+=1;
    var com = entity.Get<Component138>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
