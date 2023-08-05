using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System229 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component21,Component278,Component32> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component324>())
   {
    q+=1;
    var com = entity.Get<Component324>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component170>())
   {
    q+=1;
    var com = entity.Get<Component170>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component93>())
   {
    q+=1;
    var com = entity.Get<Component93>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component221>())
   {
    q+=1;
    var com = entity.Get<Component221>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
