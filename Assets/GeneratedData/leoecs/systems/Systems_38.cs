using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System38 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component221,Component161> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component73>())
   {
    q+=1;
    var com = entity.Get<Component73>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component149>())
   {
    q+=1;
    var com = entity.Get<Component149>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component377>())
   {
    q+=1;
    var com = entity.Get<Component377>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component156>())
   {
    q+=1;
    var com = entity.Get<Component156>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
