using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System73 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component339> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component293>())
   {
    q+=1;
    var com = entity.Get<Component293>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component487>())
   {
    q+=1;
    var com = entity.Get<Component487>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component370>())
   {
    q+=1;
    var com = entity.Get<Component370>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component65>())
   {
    q+=1;
    var com = entity.Get<Component65>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
