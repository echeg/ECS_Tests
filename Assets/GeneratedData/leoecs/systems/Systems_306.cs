using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System306 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component220,Component382,Component278> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component87>())
   {
    q+=1;
    var com = entity.Get<Component87>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component432>())
   {
    q+=1;
    var com = entity.Get<Component432>();
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
   if (entity.Has<Component353>())
   {
    q+=1;
    var com = entity.Get<Component353>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
