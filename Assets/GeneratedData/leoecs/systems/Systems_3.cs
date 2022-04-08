using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System3 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component419,Component396> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component197>())
   {
    q+=1;
    var com = entity.Get<Component197>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component125>())
   {
    q+=1;
    var com = entity.Get<Component125>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component196>())
   {
    q+=1;
    var com = entity.Get<Component196>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component407>())
   {
    q+=1;
    var com = entity.Get<Component407>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
