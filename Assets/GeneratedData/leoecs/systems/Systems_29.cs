using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System29 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component326,Component261,Component171> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component127>())
   {
    q+=1;
    var com = entity.Get<Component127>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component167>())
   {
    q+=1;
    var com = entity.Get<Component167>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component286>())
   {
    q+=1;
    var com = entity.Get<Component286>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component448>())
   {
    q+=1;
    var com = entity.Get<Component448>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
