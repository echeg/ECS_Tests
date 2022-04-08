using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System28 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component499,Component99,Component385,Component110> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component65>())
   {
    q+=1;
    var com = entity.Get<Component65>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component305>())
   {
    q+=1;
    var com = entity.Get<Component305>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component463>())
   {
    q+=1;
    var com = entity.Get<Component463>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component406>())
   {
    q+=1;
    var com = entity.Get<Component406>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
