using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System272 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component94,Component245,Component157> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component111>())
   {
    q+=1;
    var com = entity.Get<Component111>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component124>())
   {
    q+=1;
    var com = entity.Get<Component124>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component362>())
   {
    q+=1;
    var com = entity.Get<Component362>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component186>())
   {
    q+=1;
    var com = entity.Get<Component186>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
