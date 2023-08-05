using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System285 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component214,Component70> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component388>())
   {
    q+=1;
    var com = entity.Get<Component388>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component230>())
   {
    q+=1;
    var com = entity.Get<Component230>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component241>())
   {
    q+=1;
    var com = entity.Get<Component241>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component75>())
   {
    q+=1;
    var com = entity.Get<Component75>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
