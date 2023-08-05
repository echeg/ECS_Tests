using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System331 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component424,Component405,Component144,Component473> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component322>())
   {
    q+=1;
    var com = entity.Get<Component322>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component437>())
   {
    q+=1;
    var com = entity.Get<Component437>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component423>())
   {
    q+=1;
    var com = entity.Get<Component423>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component402>())
   {
    q+=1;
    var com = entity.Get<Component402>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
