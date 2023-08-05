using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System203 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component384,Component23> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component433>())
   {
    q+=1;
    var com = entity.Get<Component433>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component60>())
   {
    q+=1;
    var com = entity.Get<Component60>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component240>())
   {
    q+=1;
    var com = entity.Get<Component240>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component373>())
   {
    q+=1;
    var com = entity.Get<Component373>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
