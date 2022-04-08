using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System77 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component357,Component109,Component346> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component384>())
   {
    q+=1;
    var com = entity.Get<Component384>();
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
   if (entity.Has<Component90>())
   {
    q+=1;
    var com = entity.Get<Component90>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component298>())
   {
    q+=1;
    var com = entity.Get<Component298>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
