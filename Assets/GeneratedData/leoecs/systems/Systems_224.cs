using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System224 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component455,Component465,Component202> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component259>())
   {
    q+=1;
    var com = entity.Get<Component259>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component244>())
   {
    q+=1;
    var com = entity.Get<Component244>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component292>())
   {
    q+=1;
    var com = entity.Get<Component292>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component92>())
   {
    q+=1;
    var com = entity.Get<Component92>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
