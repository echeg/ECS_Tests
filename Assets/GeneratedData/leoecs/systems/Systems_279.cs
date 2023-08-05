using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System279 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component343,Component437> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component390>())
   {
    q+=1;
    var com = entity.Get<Component390>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component18>())
   {
    q+=1;
    var com = entity.Get<Component18>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component282>())
   {
    q+=1;
    var com = entity.Get<Component282>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
