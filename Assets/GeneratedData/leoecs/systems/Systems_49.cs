using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System49 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component168,Component251,Component405,Component433> _filter = null;
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
   if (entity.Has<Component50>())
   {
    q+=1;
    var com = entity.Get<Component50>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component343>())
   {
    q+=1;
    var com = entity.Get<Component343>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component153>())
   {
    q+=1;
    var com = entity.Get<Component153>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
