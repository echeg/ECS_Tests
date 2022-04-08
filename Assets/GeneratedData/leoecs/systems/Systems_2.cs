using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System2 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component241> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component461>())
   {
    q+=1;
    var com = entity.Get<Component461>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component283>())
   {
    q+=1;
    var com = entity.Get<Component283>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component10>())
   {
    q+=1;
    var com = entity.Get<Component10>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component424>())
   {
    q+=1;
    var com = entity.Get<Component424>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
