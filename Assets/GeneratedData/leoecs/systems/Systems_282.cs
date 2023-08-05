using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System282 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component419> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component176>())
   {
    q+=1;
    var com = entity.Get<Component176>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component335>())
   {
    q+=1;
    var com = entity.Get<Component335>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component443>())
   {
    q+=1;
    var com = entity.Get<Component443>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component204>())
   {
    q+=1;
    var com = entity.Get<Component204>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
