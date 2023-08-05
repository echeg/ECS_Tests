using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System293 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component106,Component425,Component373,Component270> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component70>())
   {
    q+=1;
    var com = entity.Get<Component70>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component335>())
   {
    q+=1;
    var com = entity.Get<Component335>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component213>())
   {
    q+=1;
    var com = entity.Get<Component213>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component418>())
   {
    q+=1;
    var com = entity.Get<Component418>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
