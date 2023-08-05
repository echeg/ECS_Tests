using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System258 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component226,Component356,Component161,Component54> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component44>())
   {
    q+=1;
    var com = entity.Get<Component44>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component185>())
   {
    q+=1;
    var com = entity.Get<Component185>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component73>())
   {
    q+=1;
    var com = entity.Get<Component73>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component323>())
   {
    q+=1;
    var com = entity.Get<Component323>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
