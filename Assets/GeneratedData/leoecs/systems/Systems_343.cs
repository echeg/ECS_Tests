using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System343 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component312> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component228>())
   {
    q+=1;
    var com = entity.Get<Component228>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component269>())
   {
    q+=1;
    var com = entity.Get<Component269>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component46>())
   {
    q+=1;
    var com = entity.Get<Component46>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component333>())
   {
    q+=1;
    var com = entity.Get<Component333>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
