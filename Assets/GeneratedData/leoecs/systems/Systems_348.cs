using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System348 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component206,Component128,Component109,Component406> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component53>())
   {
    q+=1;
    var com = entity.Get<Component53>();
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
   if (entity.Has<Component173>())
   {
    q+=1;
    var com = entity.Get<Component173>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component179>())
   {
    q+=1;
    var com = entity.Get<Component179>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
