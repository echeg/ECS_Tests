using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System207 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component386,Component133,Component75,Component301> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component175>())
   {
    q+=1;
    var com = entity.Get<Component175>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component159>())
   {
    q+=1;
    var com = entity.Get<Component159>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component235>())
   {
    q+=1;
    var com = entity.Get<Component235>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component390>())
   {
    q+=1;
    var com = entity.Get<Component390>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
