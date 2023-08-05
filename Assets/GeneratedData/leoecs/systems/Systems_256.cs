using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System256 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component459,Component210,Component195> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component377>())
   {
    q+=1;
    var com = entity.Get<Component377>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component244>())
   {
    q+=1;
    var com = entity.Get<Component244>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component417>())
   {
    q+=1;
    var com = entity.Get<Component417>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component384>())
   {
    q+=1;
    var com = entity.Get<Component384>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
