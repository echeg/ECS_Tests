using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System37 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component248,Component429,Component97,Component128> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component100>())
   {
    q+=1;
    var com = entity.Get<Component100>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component320>())
   {
    q+=1;
    var com = entity.Get<Component320>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component409>())
   {
    q+=1;
    var com = entity.Get<Component409>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component237>())
   {
    q+=1;
    var com = entity.Get<Component237>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
