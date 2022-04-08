using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System8 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component103,Component326,Component39,Component401> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component417>())
   {
    q+=1;
    var com = entity.Get<Component417>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component205>())
   {
    q+=1;
    var com = entity.Get<Component205>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component161>())
   {
    q+=1;
    var com = entity.Get<Component161>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component83>())
   {
    q+=1;
    var com = entity.Get<Component83>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
