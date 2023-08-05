using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System226 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component440,Component244> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component418>())
   {
    q+=1;
    var com = entity.Get<Component418>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component413>())
   {
    q+=1;
    var com = entity.Get<Component413>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component372>())
   {
    q+=1;
    var com = entity.Get<Component372>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component442>())
   {
    q+=1;
    var com = entity.Get<Component442>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
