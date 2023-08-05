using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System261 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component171,Component352> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component394>())
   {
    q+=1;
    var com = entity.Get<Component394>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component442>())
   {
    q+=1;
    var com = entity.Get<Component442>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component189>())
   {
    q+=1;
    var com = entity.Get<Component189>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component308>())
   {
    q+=1;
    var com = entity.Get<Component308>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
