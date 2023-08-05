using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System251 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component279,Component134,Component107> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component304>())
   {
    q+=1;
    var com = entity.Get<Component304>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component253>())
   {
    q+=1;
    var com = entity.Get<Component253>();
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
   if (entity.Has<Component469>())
   {
    q+=1;
    var com = entity.Get<Component469>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
