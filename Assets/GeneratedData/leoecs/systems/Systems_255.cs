using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System255 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component173,Component233,Component343> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component403>())
   {
    q+=1;
    var com = entity.Get<Component403>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component191>())
   {
    q+=1;
    var com = entity.Get<Component191>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component105>())
   {
    q+=1;
    var com = entity.Get<Component105>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component259>())
   {
    q+=1;
    var com = entity.Get<Component259>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
