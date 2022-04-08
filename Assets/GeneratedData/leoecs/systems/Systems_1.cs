using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System1 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component362,Component466,Component190,Component254> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component366>())
   {
    q+=1;
    var com = entity.Get<Component366>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component225>())
   {
    q+=1;
    var com = entity.Get<Component225>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component192>())
   {
    q+=1;
    var com = entity.Get<Component192>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
