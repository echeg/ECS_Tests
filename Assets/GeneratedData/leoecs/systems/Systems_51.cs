using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System51 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component370> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component85>())
   {
    q+=1;
    var com = entity.Get<Component85>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component318>())
   {
    q+=1;
    var com = entity.Get<Component318>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component144>())
   {
    q+=1;
    var com = entity.Get<Component144>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component142>())
   {
    q+=1;
    var com = entity.Get<Component142>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
