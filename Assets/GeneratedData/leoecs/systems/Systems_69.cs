using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System69 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component135,Component453,Component413,Component187> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component152>())
   {
    q+=1;
    var com = entity.Get<Component152>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component396>())
   {
    q+=1;
    var com = entity.Get<Component396>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
