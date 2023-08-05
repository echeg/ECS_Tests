using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System212 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component275> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component498>())
   {
    q+=1;
    var com = entity.Get<Component498>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component250>())
   {
    q+=1;
    var com = entity.Get<Component250>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component139>())
   {
    q+=1;
    var com = entity.Get<Component139>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component242>())
   {
    q+=1;
    var com = entity.Get<Component242>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
