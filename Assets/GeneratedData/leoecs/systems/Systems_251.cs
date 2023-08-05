using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System251 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component175,Component137,Component114,Component194> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component318>())
   {
    q+=1;
    var com = entity.Get<Component318>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component322>())
   {
    q+=1;
    var com = entity.Get<Component322>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component129>())
   {
    q+=1;
    var com = entity.Get<Component129>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component293>())
   {
    q+=1;
    var com = entity.Get<Component293>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
