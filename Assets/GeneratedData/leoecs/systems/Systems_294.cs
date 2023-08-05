using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System294 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component385,Component311,Component405,Component272> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component352>())
   {
    q+=1;
    var com = entity.Get<Component352>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component379>())
   {
    q+=1;
    var com = entity.Get<Component379>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component453>())
   {
    q+=1;
    var com = entity.Get<Component453>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component245>())
   {
    q+=1;
    var com = entity.Get<Component245>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
