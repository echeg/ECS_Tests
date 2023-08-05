using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System342 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component219,Component414> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component429>())
   {
    q+=1;
    var com = entity.Get<Component429>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component331>())
   {
    q+=1;
    var com = entity.Get<Component331>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component3>())
   {
    q+=1;
    var com = entity.Get<Component3>();
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
