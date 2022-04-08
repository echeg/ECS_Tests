using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System27 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component442,Component355> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component426>())
   {
    q+=1;
    var com = entity.Get<Component426>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component161>())
   {
    q+=1;
    var com = entity.Get<Component161>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component428>())
   {
    q+=1;
    var com = entity.Get<Component428>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component324>())
   {
    q+=1;
    var com = entity.Get<Component324>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
