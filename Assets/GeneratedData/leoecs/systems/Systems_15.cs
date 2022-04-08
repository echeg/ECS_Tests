using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System15 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component480,Component214,Component24,Component340> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component469>())
   {
    q+=1;
    var com = entity.Get<Component469>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component37>())
   {
    q+=1;
    var com = entity.Get<Component37>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component77>())
   {
    q+=1;
    var com = entity.Get<Component77>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component257>())
   {
    q+=1;
    var com = entity.Get<Component257>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
