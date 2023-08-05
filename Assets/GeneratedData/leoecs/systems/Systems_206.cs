using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System206 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component279> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component294>())
   {
    q+=1;
    var com = entity.Get<Component294>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component28>())
   {
    q+=1;
    var com = entity.Get<Component28>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component475>())
   {
    q+=1;
    var com = entity.Get<Component475>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component318>())
   {
    q+=1;
    var com = entity.Get<Component318>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
