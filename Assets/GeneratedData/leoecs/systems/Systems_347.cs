using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System347 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component492,Component340,Component459> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component284>())
   {
    q+=1;
    var com = entity.Get<Component284>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component354>())
   {
    q+=1;
    var com = entity.Get<Component354>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component133>())
   {
    q+=1;
    var com = entity.Get<Component133>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component472>())
   {
    q+=1;
    var com = entity.Get<Component472>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
