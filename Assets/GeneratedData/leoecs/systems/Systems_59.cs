using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System59 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component64> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component166>())
   {
    q+=1;
    var com = entity.Get<Component166>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component153>())
   {
    q+=1;
    var com = entity.Get<Component153>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component145>())
   {
    q+=1;
    var com = entity.Get<Component145>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component478>())
   {
    q+=1;
    var com = entity.Get<Component478>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
